using System.Data.Entity;

namespace CoffeeShop.model
{
    public class CoffeeDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}