using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKoe
{
    class Product
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Constructor
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        // Method
        public decimal CalculateDiscountedPrice(decimal discountPercentage)
        {
            return Price * discountPercentage;
        }
    }
}
