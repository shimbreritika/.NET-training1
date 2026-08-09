using _4AUG.Models;
using Microsoft.EntityFrameworkCore;

namespace _4AUG.Data
{
    public class AppDbContext : DbContext //from entity framework
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

       
    }
}
