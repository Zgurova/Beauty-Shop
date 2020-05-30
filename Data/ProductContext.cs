using System;
using Microsoft.EntityFrameworkCore;
using products;

namespace Data
{
    /// <summary>
    /// Inherrits the class DbContext which is needed for the project
    /// </summary>
    public class ProductContext : DbContext
    {
        // Constructor
        public ProductContext()
        {

        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {

        }

        // Tables from database
        public DbSet<Perfume> Perfumes { get; set; }
        public DbSet<Cream> Creams { get; set; }
        public DbSet<MakeUp> MakeUp { get; set; }
        public DbSet<Cart> Cart { get; set; }

        // Overrides 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Connection.ConnectionString).UseLazyLoadingProxies();
            }

        }

        // Overrides
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
