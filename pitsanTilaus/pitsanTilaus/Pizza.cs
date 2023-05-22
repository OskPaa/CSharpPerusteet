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
            Toppings = new List<Topping>(); // Lista pizzan täytteistä
            BasePrice = 15M; // Pizzan vakiohinta
        }
        // Methods
        public decimal CalculatePrice()
        {
            if (Toppings.Count < 4) // Tapaukset, jossa palautetaan vakiohinta
            {
                return BasePrice; // Palautetaan vakiohinta
            }
            else // muut tapaukset (Täytteitä on enemmän kuin 3)
            {
                return BasePrice + (Toppings.Count - 3); // Palautetaan uusi laskettu hinta 
            }
        }
    }
}
