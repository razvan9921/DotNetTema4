using Microsoft.EntityFrameworkCore;
using TemaPatru.Entities;

namespace TemaPatru
{
    public sealed class ProductAndCustomerManagementContext : DbContext
    {
        public ProductAndCustomerManagementContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<ProductEntity> Products{ get; set; }

        public DbSet<CustomerEntity> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=Dotnet;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CustomerEntity>()
              .Property(t => t.Address).IsRequired().HasMaxLength(300);

            modelBuilder.Entity<CustomerEntity>()
                .Property(t => t.Email).IsRequired();

            modelBuilder.Entity<CustomerEntity>()
                .Property(t => t.Name).HasMaxLength(100);

            modelBuilder.Entity<CustomerEntity>()
                .Property(t => t.PhoneNumber).IsRequired();
        }
    }
}