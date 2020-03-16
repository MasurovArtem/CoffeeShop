using System.Data.Entity;

namespace CoffeeShop.model
{
    public class CoffeeDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductsTypes { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}