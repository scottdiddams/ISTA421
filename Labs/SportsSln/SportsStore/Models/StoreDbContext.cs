using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }
        public DbSet<Product> Products { get; set; }
        //use a dbset to enforce entity integrity - avoiding duplicates
    }
}
