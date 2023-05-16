using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ostokset
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ShoppingList> order = new List<ShoppingList>();

            Console.Write("Mihin kauppaan tehdään ostoslista: ");
            string shop = Console.ReadLine();
            
            ShoppingList newOrder = new ShoppingList(shop);
            bool userExitsProductsLoop = false;
            do // Käyttäjä lisää ostoksia
            {
                Console.Clear();
                Console.WriteLine($"Valittu kauppa on {newOrder.ShopName}");
                Console.WriteLine();

                // Näytetään valitut tuotteet

                newOrder.PrintProduct();

                Console.Write("Syötä tuote ja lukumäärä(maito, 3): ");
                string input = Console.ReadLine();
                if(input != "")
                {
                    string[] splitInput = input.Split(',');
                    int amount = int.Parse(splitInput[1].Trim());

                    for(int i = 1; i <= amount; i++)
                    {
                        newOrder.AddProduct(splitInput[0]);
                    }
                }
                else
                {
                    userExitsProductsLoop = true;
                }
            } while (!userExitsProductsLoop);

            Console.WriteLine();
            Console.WriteLine($"Ostoksien summa: {newOrder.Sum}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
