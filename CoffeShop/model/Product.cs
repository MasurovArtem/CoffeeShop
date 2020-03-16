using System;
using System.Drawing;
using System.Net.Mime;

namespace CoffeeShop.model
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
    }
}