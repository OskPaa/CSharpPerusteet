using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toistoLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1; // Alustetaan loopin laskuri
            Console.Write("Anna lukua 1 suurempi luku:"); // Kysytään käyttäjältä syötettävä luku
            int finalNumber = int.Parse(Console.ReadLine()); // Käyttäjä syöttää luvun (samalla alustus)

            while (finalNumber <= 1) // Tehdään looppi, joka tarkistaa syötetyn luvun kelpoisuuden 
            {
                Console.Write("Anna lukua 1 suurempi luku:"); // Kysytään lukua uudestaan
                finalNumber = int.Parse(Console.ReadLine()); // Otetaan vastaan uusi luku käyttäjältä
            }

            while (counter <= finalNumber) // Looppi, jossa laskurin arvo nousee ja tulostus tapahtuu 
            {
                Console.Write($"{counter}, "); // Tulostetaan laskurin sen hetkinen arvo 
                counter++; // Nostetaan laskurin arvoa yhdellä
            }

            for (int i = 0;i<=finalNumber;i++) 
            {
                Console.Write($"{i}, ");
            }

            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
