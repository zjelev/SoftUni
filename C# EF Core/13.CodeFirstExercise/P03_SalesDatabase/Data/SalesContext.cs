using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Sales;Integrated Security=true");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsUnicode();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsUnicode();

                entity.Property(e => e.Email)
                    .IsUnicode(false);

                entity.Property(e => e.CreditCardNumber)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsUnicode();
            });

        }

    }
}