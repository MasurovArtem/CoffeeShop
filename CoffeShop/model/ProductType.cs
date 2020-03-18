using System.Collections.Generic;

namespace CoffeeShop.model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Description { get; set; }

       
        public ICollection<Product> Product { get; set; }
    }
}