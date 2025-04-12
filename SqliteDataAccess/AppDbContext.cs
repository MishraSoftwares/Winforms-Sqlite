
namespace SqliteDataAccess
{
    // Data/AppDbContext.cs
    using Microsoft.EntityFrameworkCore;
    using SqliteDataAccess.Entities;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
