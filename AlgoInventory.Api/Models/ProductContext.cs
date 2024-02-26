using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AlgoInventory.Api.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Description = "Description 1", Quantity = 10 },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2", Quantity = 20 }
            );
        }

        public DbSet<Product> Products { get; set; } = null!;
    }
}
