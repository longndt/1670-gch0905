using demoweb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace demoweb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //tự động tạo bảng từ Model
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

        //tạo code add dữ liệu khởi tạo cho bảng
        protected void onModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedCategory(modelBuilder);
            SeedProduct(modelBuilder);
        }

        private void SeedCategory (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Laptop", Description = "Máy tính xách tay", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfrIQWjYmbZEvcaqfhrJ5KRfvZ8B3mPm5uKw&usqp=CAU" },
                new Category { Id = 2, Name = "Desktop", Description = "Máy tính để bàn", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRLWsLnuU2C828w1pvkxgSJN_CWKrHCD-5Knw&usqp=CAU" },
                new Category { Id = 3, Name = "Mobile", Description = "Điện thoại di động", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6WUOnhg9tjr_dpuI6zGVlHvrDcvHHFGDbRQ&usqp=CAU" }
            );
            //Note: bắt buộc phải khai báo Id (PK) thủ công vì mặc định không có
        }

        private void SeedProduct (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Asus", Price = 1000, Quantity = 10, Date = DateTime.Parse("25/02/2022"), CategoryId = 1 },
                new Product { Id = 2, Name = "Dell", Price = 2000, Quantity = 20, Date = DateTime.Parse("20/04/2021"), CategoryId = 1 },
                new Product { Id = 3, Name = "HP", Price = 3000, Quantity = 30, Date = DateTime.Parse("12/07/2020"), CategoryId = 2 },
                new Product { Id = 4, Name = "Lenovo", Price = 4000, Quantity = 40, Date = DateTime.Parse("29/08/2020"), CategoryId = 2 },
                new Product { Id = 5, Name = "Samsung", Price = 1200, Quantity = 60, Date = DateTime.Parse("16/01/2018"), CategoryId = 3 },
                new Product { Id = 6, Name = "iPhone", Price = 1100, Quantity = 50, Date = DateTime.Parse("18/05/2015"), CategoryId = 3}
            );  
        }
    }
}
