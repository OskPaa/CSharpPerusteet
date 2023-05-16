using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ostokset
{
    // Voidaan luoda ostoslistoja eri kaupoille
    // Tuote lisätessä listaan "haetaan" tuotteen hinta
    class ShoppingList
    {
        // Properties

        public string ShopName { get; set; }
        public List<Product> Products { get; }

        public decimal Sum { get; set; }

        // Constructor

        public ShoppingList(string shopName)
        {
            ShopName = shopName;
            Sum = 0;
            Products = new List<Product>();
        }

        // Methods

        public void AddProduct(string productName)
        {
            Product temp = new Product(productName);
            Products.Add(temp);
            Sum += temp.Price;
        }

        public void PrintProduct()
        {
            for(int i=0;i < Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Products[i].Name}\t\t\t{Products[i].Price}");
            }
        }
    }
}
