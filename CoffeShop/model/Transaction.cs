using System;
using System.Collections.Generic;

namespace CoffeeShop.model
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime? TransactionDate { get; set; }
            
        public ICollection<TransactionItem> TransactionItem { get; set; }
    }
}