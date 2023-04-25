using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensaLuokat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trip> trips = new List<Trip>();

            bool userEndsLoop = false;

            while(userEndsLoop == false)
            {
                Console.Write("Syötä matkan nimi: ");
                string name = Console.ReadLine();

                Console.Write("Syötä ajettu matka(km): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Syötä keskikulutus(l/100km): ");
                double averageConsumption = double.Parse(Console.ReadLine());

                Console.Write("Syötä polttoaineen hinta(euro/l): ");
                double fuelPrice = double.Parse(Console.ReadLine());

                trips.Add(new Trip(name,distance, averageConsumption, fuelPrice));

                Console.Write("Syötetään uusi matka(y): ");
                string input = Console.ReadLine();

                if (input != "y")
                {
                    userEndsLoop = true;
                }
            }

            foreach(Trip t in trips)
            {
                Console.WriteLine($"Matkan {t.Name} hinta on: {t.CalculateCost()}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
