using _14AUG.Model;
using Microsoft.EntityFrameworkCore;

namespace _14AUG.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers => Set<Customer>();

        public DbSet<Product> Products => Set<Product>();

        public DbSet<CustomerProduct> CustomersProduct => Set<CustomerProduct>();

        public DbSet<User> User => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CustomerProduct>().HasKey(cp => new { cp.CustomerId, cp.ProductId });

            //customer -> customerproduct
            modelBuilder.Entity<CustomerProduct>().HasOne(cp => cp.Customer).WithMany(c => c.CustomerProducts).HasForeignKey(cp => cp.CustomerId).OnDelete(DeleteBehavior.Cascade);

            //ptoduct -> customerproduct
            modelBuilder.Entity<CustomerProduct>().HasOne(cp => cp.Product).WithMany(c => c.CustomerProducts).HasForeignKey(cp => cp.ProductId).OnDelete(DeleteBehavior.Cascade);

            //email must be unique
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

            //auth
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
                     UserName = "customer",
                     Password = "1234",
                     Role = "Customer"
                 }



                );

        }

       
    }
}
