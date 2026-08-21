using _17_AugRest.Models;
using Microsoft.EntityFrameworkCore;

namespace _17_AugRest.Data
{
    public class AppDbContext : DbContext
    {
        //constructor accept configuration options & passes them to base class
        //ensure proper db provider & connection string setup
        public AppDbContext(DbContextOptions options) : base(options) { }

        //maps Product entity class to a corresponding db table 
        //query, save data
        public DbSet<Product> products { get; set; }

        public DbSet<User> Users12 { get; set; }

        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Product -> Category relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "admin",
                    Password = "1234",
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    UserName = "user1",
                    Password = "1234",
                    Role = "Customer"
                }
            );
        }
    }
}
