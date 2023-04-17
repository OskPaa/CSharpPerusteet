using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampoTaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatureArray = new double[4];
            List<double> temperatureList = new List<double>();

            int timeOfDay = 6;

            for(int i = 0; i < temperatureArray.Length; i++)
            {
                Console.Write($"Anna klo {timeOfDay} lämpötila: ");
                temperatureArray[i] = double.Parse(Console.ReadLine());
                temperatureList.Add(temperatureArray[i]);
                timeOfDay += 6;
            }
            
            // Tulostetaan ääri- ja keskiarvot valmiilla metodeilla
            Console.WriteLine($"Päivän matalin lämpötila oli {temperatureArray.Min()} astetta.");
            Console.WriteLine($"Päivän korkein lämpötila oli {temperatureArray.Max()} astetta.");
            Console.WriteLine($"Päivän keskilämpötila oli {temperatureArray.Average()} astetta.");
            
            double min = temperatureArray[0], max = temperatureArray[0], average = 0d;

            foreach (double temperature in temperatureList)
            {
                average += temperature;
                if (temperature < min)
                {
                    min = temperature;
                }
                if (temperature >max)
                {
                    max = temperature;
                }
            }

            average /= 4;

            // Tulostetaan omalla koodilla saadut tulokset
            Console.WriteLine();
            Console.WriteLine($"Päivän matalin lämpötila oli {min} astetta.");
            Console.WriteLine($"Päivän korkein lämpötila oli {max} astetta.");
            Console.WriteLine($"Päivän keskilämpötila oli {average} astetta.");


            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
