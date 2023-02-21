using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Categories> Categories { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Region> Region { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed Department Table
            modelBuilder.Entity<Categories>().HasData(
               new Categories { CategoryID = 1, CategoryName = "IT", Description = "drink" });
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryID = 2, CategoryName = "HR", Description = "food" });
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryID = 3, CategoryName = "Payroll", Description = "toy" });
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryID = 4, CategoryName = "Admin", Description = "fast-food" });

            //Seed Employee Table
            modelBuilder.Entity<Employees>().HasData(new Employees
            {
                EmployeeID = 1,
                FirstName = "John",
                LastName = "Hastings",
                Title = "IT",
                TitleOfCourtesy = "MR.",
                BirthDate = new DateTime(1980, 10, 5),
                City = "London",
                Country = "UK",
            }) ;

            modelBuilder.Entity<Employees>().HasData(new Employees
            {
                EmployeeID = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Title = "IT",
                TitleOfCourtesy = "MR.",
                BirthDate = new DateTime(1980, 10, 5),
                City = "London",
                Country = "UK",
            });

            modelBuilder.Entity<Employees>().HasData(new Employees
            {
                EmployeeID = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Title = "IT",
                TitleOfCourtesy = "MR.",
                BirthDate = new DateTime(1980, 10, 5),
                City = "London",
                Country = "UK",
            });

            modelBuilder.Entity<Employees>().HasData(new Employees
            {
                EmployeeID = 4,
                FirstName = "Sara",
                LastName = "Longway",
                Title = "IT",
                TitleOfCourtesy = "MR.",
                BirthDate = new DateTime(1980, 10, 5),
                City = "London",
                Country = "UK",
            });

        }
    }
    
}