using _7AUG.Model;
using Microsoft.EntityFrameworkCore;

namespace _7AUG.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor receives database configuration through DI
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Products table
        public DbSet<Product> Products => Set<Product>();

        // Orders table
        public DbSet<Order> Orders => Set<Order>();

        // Configure relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One Product -> Many OrderItems
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(o => o.ProductId);

            // One Order -> Many OrderItems
            modelBuilder.Entity<OrderItem>()
                .HasOne(o => o.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(o => o.OrderId);
        }
    }
}