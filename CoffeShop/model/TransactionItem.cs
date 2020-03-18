using System.Collections.Generic;
using CoffeeShop.model;

namespace CoffeeShop
{
    public class TransactionItem
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}