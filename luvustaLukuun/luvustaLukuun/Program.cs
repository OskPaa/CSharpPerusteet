using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luvustaLukuun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä numerot ja otetaan käyttäjän syötteet
            Console.Write("Anna luku, josta laskeminen aloitetaan:");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Anna luku, johon laskeminen lopetetaan:");
            int end = int.Parse(Console.ReadLine());

            if (start < end) // Tapaukset, joissa aloitusluku on pienempi 
            {
                for (int i = start; i <= end; i++) // Määritetään for-loopin toimintaperiaate 
                {
                    Console.Write($"{i}, "); // Loopin sisäinen tulostus
                }
            }
            else if (end < start) // Tapaukset, joissa aloitusluku on suurempi 
            {
                for (int i = start; i >= end; i--) // Määritetään for-loopin toimintaperiaate 
                {
                    {
                        Console.Write($"{i}, "); // Loopin sisäinen tulostus
                    }
                }
            }
            else // Poikkeustapauksille
            {
                Console.WriteLine($"Laskua numerosta {start} numeroon {end} ei voi tehdä!"); // Virhe ilmoitus
            }
            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
