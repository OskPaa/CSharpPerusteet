using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitsanTilaus
{
    class Pizza
    {
       // Properties
        public List<Topping> Toppings { get; set; }
        public decimal BasePrice { get; set; }
        // Constructor
        public Pizza()
        {
            Toppings = new List<Topping>();
            BasePrice = 15M;
        }
        // Methods
        public decimal CalculatePrice()
        {
            if (Toppings.Count < 4)
            {
                return BasePrice;
            }
            else
            {
                return BasePrice + (Toppings.Count - 3);
            }
        }
    }
}
