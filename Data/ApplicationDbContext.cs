using DaPe.Models;
using Microsoft.EntityFrameworkCore;

namespace DaPe.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<KindOfProduct> TypeOfProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Plyn", DisplayCategoryNr = 1},
                new Category { Id = 2, Name = "Voda", DisplayCategoryNr = 2},
                new Category { Id = 3, Name = "Elektrika", DisplayCategoryNr = 3}
                
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, NameOfProduct = "Vodoměr hlavní", DisplayProductNr = "Doplň číslo měřáku", Description = "Hlavní vodoměr venku za zámečkem", CategoryId = 1, KindOfProductId = 1, ImageUrl = ""},
                new Product { Id = 2, NameOfProduct = "Vodoměr - budova 7", DisplayProductNr = "Doplň číslo měřáku", Description = "Rozvodna vody na středisku 320 - dveře č. - ???", CategoryId = 1, KindOfProductId = 1,ImageUrl = ""},
                new Product { Id = 3, NameOfProduct = "Vodoměr-M24-dole", DisplayProductNr = "Doplň číslo měřáku", Description = "Umístění - dole v rozvodně budovy M24 dveře č. ???", CategoryId = 1, KindOfProductId = 1, ImageUrl =""}
            );

            modelBuilder.Entity<KindOfProduct>().HasData(
                new KindOfProduct { Id = 1, TypeOfProduct = "Hlavní měřidlo", DisplayTypeOfProductNr = 1 },
                new KindOfProduct { Id = 2, TypeOfProduct = "Podružné měřidlo", DisplayTypeOfProductNr = 2 },
                new KindOfProduct { Id = 3, TypeOfProduct = "Dopočtené měřidlo", DisplayTypeOfProductNr = 3 }
            );
        }
    }
}
