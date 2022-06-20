using demo123.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demo123.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tự động tạo bảng từ file Model
        public DbSet<Laptop> Laptop { get; set; }

        //add dữ liệu ban đầu vào bảng trong DB bằng code
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedLaptop(builder);
        }

        private void SeedLaptop(ModelBuilder builder)
        {
            builder.Entity<Laptop>().HasData(
           new Laptop { Id = 1, Name = "XPS 13", Price = 1000, Manufacturer = "Dell" },
           new Laptop { Id = 2, Name = "XPS 13", Price = 1000, Manufacturer = "Dell" },
           new Laptop { Id = 3, Name = "XPS 13", Price = 1000, Manufacturer = "Dell" },
           new Laptop { Id = 4, Name = "XPS 13", Price = 1000, Manufacturer = "Dell" },
           new Laptop { Id = 5, Name = "XPS 13", Price = 1000, Manufacturer = "Dell" }
            );
        }
    }        
}
