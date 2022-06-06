using Microsoft.EntityFrameworkCore;
using webdemo.Models;

//Tools => NuGet Package Manager => Package Manager Console
// => Install-Package: Microsoft.EntityFrameworkCore (version : 5.0.10)

namespace webdemo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
    }
}
