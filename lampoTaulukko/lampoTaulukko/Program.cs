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
            List<(int,double)> temperatureList = new List<(int,double)>();

            int timeOfDay = 6;

            for(int i = 0; i < temperatureArray.Length; i++)
            {
                Console.Write($"Anna klo {timeOfDay}.00 lämpötila: "); // Kysytään käyttäjältä lämpötilaa
                temperatureArray[i] = double.Parse(Console.ReadLine()); // Tallenetaan käyttäjän syöte taulukkoon
                temperatureList.Add((timeOfDay,temperatureArray[i])); // Kopioidaan taulukon tieto listaan 
                timeOfDay += 6; // Päivitetään "kellonaika" seuraavaa kierrosta varten
            }

            // Tulostetaan ääri- ja keskiarvot valmiilla metodeilla
            Console.WriteLine();
            Console.WriteLine($"Päivän matalin lämpötila oli {temperatureArray.Min()} astetta.");
            Console.WriteLine($"Päivän korkein lämpötila oli {temperatureArray.Max()} astetta.");
            Console.WriteLine($"Päivän keskilämpötila oli {temperatureArray.Average()} astetta.");
            
            double min = temperatureArray[0], max = temperatureArray[0], average = 0d; // Määritetään tulostettavat double-arvot foreach-loopin ulkopuolella
            int maxTime = 6, minTime = 6; // Määritetään tulostettavat int-arvot foreach-loopin ulkopuolella

            foreach ((int,double) temperature in temperatureList) // Looppi, jossa selvitetään minimi ja maksimi lämpötilat
            {
                average += temperature.Item2; // Lisätään tämän hetkinen lämpötila keskiarvon laskettavaan muuttujaan
                if (temperature.Item2 < min) // Tarkistetaan on minimiarvo pienempi kuin tämän hetkinen arvo
                {
                    min = temperature.Item2; // Korvataan minimiarvo pienemmällä arvolla
                    minTime = temperature.Item1; // Vaihdetaan ajankohta oikeaksi
                }
                if (temperature.Item2 > max) // Tarkistetaan on maksimiarvo suurempi kuin tämän hetkinen arvo
                {
                    max = temperature.Item2; // Korvataan maksimiarvo suuremmalla arvolla
                    maxTime = temperature.Item1; // Vaihdetaan ajankohta oikeaksi
                }
            }

            average /= 4; //Lasketaan keskiarvo jakamalla loopissa laskettu summa

            // Tulostetaan omalla koodilla saadut tulokset
            Console.WriteLine();
            Console.WriteLine($"Päivän matalin lämpötila oli {min} astetta klo {minTime}.00");
            Console.WriteLine($"Päivän korkein lämpötila oli {max} astetta klo {maxTime}.00");
            Console.WriteLine($"Päivän keskilämpötila oli {average} astetta.");


            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
