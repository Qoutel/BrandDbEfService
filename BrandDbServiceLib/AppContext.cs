using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BrandDbServiceLib
{
    public class AppContext : DbContext
    {
        public DbSet<CarBrand> CarBrands { get; set; }
        
        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarBrandDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand[]
                {
                new CarBrand { Id = 1, Name = "Tesla", Country = "USA", FoundedIn = 2003, NumberOfEmployees = 70757 },
                new CarBrand { Id = 2, Name = "BMW", Country = "German", FoundedIn = 1917, NumberOfEmployees = 133778 },
                new CarBrand { Id = 3, Name = "Audi", Country = "German", FoundedIn = 1909, NumberOfEmployees = 91674 },
                new CarBrand { Id = 4, Name = "Ferrari", Country = "Italy", FoundedIn = 1929, NumberOfEmployees = 4556 },
                new CarBrand { Id = 5, Name = "Kia", Country = "South Korea", FoundedIn = 1944, NumberOfEmployees = 52488 },
                new CarBrand { Id = 6, Name = "Mazda", Country = "Japan", FoundedIn = 1920, NumberOfEmployees = 46398 },
                new CarBrand { Id = 7, Name = "Ford", Country = "USA", FoundedIn = 1903, NumberOfEmployees = 199000 },
                new CarBrand { Id = 8, Name = "Volvo", Country = "Sweden", FoundedIn = 1927, NumberOfEmployees = 96194 }
                }); ;
        }
    }
}
