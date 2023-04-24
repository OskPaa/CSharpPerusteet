using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensanKulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] priceArray = { 0 };
            int loop = 0;
            List<double> priceList = new List<double>();
            bool isReady = false;
            while (!isReady)
            {

                Console.Write("Syötä ajettava matka(km): ");
                double distance = double.Parse(Console.ReadLine());
                Console.Write("Syötä polttoaineen kulutus(l/100km): ");
                double gasPerHundredKm = double.Parse(Console.ReadLine());
                Console.Write("Syötä polttoaineen hinta(euro/l): ");
                double gasPrice = double.Parse(Console.ReadLine());

                double price = priceOfTheTrip(distance,gasPerHundredKm,gasPrice);
                Console.WriteLine($"Matkakulut ovat {price} euroa");

                priceArray[loop] = price;
                priceList.Add(price);

                Console.Write("Tehdäänkö uusi kierros(e lopettaa):");
                string nextRound = Console.ReadLine();

                switch (nextRound)
                {
                    case "e":
                        isReady = true;
                        break;
                    default:
                        priceArray = biggerArray(priceArray);
                        loop++;
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matkojen hinnat listalla:");
            foreach (double cost in priceList)
            {
                Console.WriteLine($"{cost} euroa");
            }

            Console.WriteLine();
            Console.WriteLine("Matkojen hinnat taulukossa:");
            foreach (double cost in priceArray)
            {
                Console.WriteLine($"{cost} euroa");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static double priceOfTheTrip(double distance, double gasPerHundredKm, double gasPrice)
        {
            double result = distance * gasPerHundredKm / 100*gasPrice;
            return result;
        }
        private static double[] biggerArray(double[] oldArray)
        {
            double[] newArray = new double[oldArray.Length+1];
            int i = 0;
            foreach(double value in oldArray)
            {
                newArray[i] = value;
                i++;
            }
            return newArray;
        }
    }
}
