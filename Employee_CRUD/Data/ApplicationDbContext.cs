using Employee_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "Anish Shrestha", Email = "growwithanish@gmail.com" },
                new Employee { Id = 2, Name = "Aarjan Shrestha", Email = "aarjan@gmail.com" },
                new Employee { Id = 3, Name = "Shreni Shrestha", Email = "shreni@gmail.com" }
                );
        }
    }
}