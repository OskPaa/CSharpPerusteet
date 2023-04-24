using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampoMetodit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä lämpötila: ");
            string answer = Console.ReadLine();
            while(answer != "e")
            {
                double temperature = double.Parse(answer);
                Console.Write("Syötä, mihin yksikköön muutetaan (C) tai (F): ");
                string unit = Console.ReadLine();
                if(unit == "C")
                {
                    Console.WriteLine($"{temperature} Farenheitia on {toCelsius(temperature)} Celsiusta");
                }
                else if (unit == "F")
                {
                    Console.WriteLine($"{temperature} Celsiusta on {toFarenheit(temperature)} Farenheitia");
                }
                else
                {
                    Console.WriteLine("Kelvollista yksikköä ei syötetty!");
                }
                Console.WriteLine("Kirjoita merkki-e, jos tahdot poistua ohjelmasta");
                Console.Write("Syötä lämpötila: ");
                answer = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static double toCelsius(double temperature)
        {
            double result = (5d/9)*(temperature - 32d);
            return result;
        }
        private static double toFarenheit(double temperature)
        {
            double result = temperature * 9d / 5d + 32;
            return result;
        }
    }
}
