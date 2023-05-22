using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitsanTilaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizzan tilaus"); // Tulostetaan otsikko
            Console.WriteLine("Valiste täyte syöttämällä sitä vastaava numero"); // Kysytään käyttäjältä täyte
            Console.WriteLine("1.Pepperoni"); // Tulostetaan, millä numeroilla valitaan mikäkin täyte
            Console.WriteLine("2.Herkkusieni");
            Console.WriteLine("3.Oliivi");
            Console.WriteLine("4.Jauheliha");
            Console.WriteLine("5.Tonnikala");

            string input = Console.ReadLine();
            Pizza pizza = new Pizza();

            while (!input.Contains("e"))
            {
                if (input.Contains("1"))
                {
                    pizza.Toppings.Add(new Topping("Pepperoni"));
                }
                else if (input.Contains("2"))
                {
                    pizza.Toppings.Add(new Topping("Herkkusieni"));
                }
                else if (input.Contains("3"))
                {
                    pizza.Toppings.Add(new Topping("Oliivi"));
                }
                else if (input.Contains("4"))
                {
                    pizza.Toppings.Add(new Topping("Jauheliha"));
                }
                else
                {
                    pizza.Toppings.Add(new Topping("Tonnikala"));
                }

                Console.Clear();
                Console.WriteLine("Pizzan tilaus"); // Tulostetaan otsikko
                Console.WriteLine("Pizzasisi täytteet ovat seuraavat");
                for(int i = 0; i < pizza.Toppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{pizza.Toppings[i].Name}");
                }

                Console.WriteLine("Valiste täyte syöttämällä sitä vastaava numero(e lopettaa täytteiden lisäämisen)"); // Kysytään käyttäjältä täyte
                Console.WriteLine("1.Pepperoni"); // Tulostetaan, millä numeroilla valitaan mikäkin täyte
                Console.WriteLine("2.Herkkusieni");
                Console.WriteLine("3.Oliivi");
                Console.WriteLine("4.Jauheliha");
                Console.WriteLine("5.Tonnikala");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Tilauksesi hinta on {pizza.CalculatePrice()} euroa.");

            Console.WriteLine("Hyväksytkö tilauksesi?(k/e)");
            string accept = Console.ReadLine();

            if (accept.Contains("k"))
            {
                Console.Write("Anna osoitteesi: ");
                string address = Console.ReadLine();
                Console.WriteLine($"Toimitamme pitsasi ositteeseen {address}");
            }


            // Suljetaan ohjelma
            Console.WriteLine("Press any button to quit...");
            Console.ReadKey();
        }
    }
}
