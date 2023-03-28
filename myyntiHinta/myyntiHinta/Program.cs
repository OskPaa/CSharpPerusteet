using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyntiHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            double tenPercentDiscount = 0.90;
            double quarterDiscount = 0.75;

            Console.Write("Anna tuotteen hinta euroina:");
            double price = double.Parse(Console.ReadLine());
            
            if ((price > 0) && (price <= 100))
            {
                price *= tenPercentDiscount;
                Console.WriteLine($"Hinta on {price} euroa");
            }
            else if (price > 100)
            {
                price *= quarterDiscount;
                Console.WriteLine($"Hinta on {price} euroa");
            }
            else
            {
                Console.WriteLine("Hintaa ei voi laskea!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
