using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjainPois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna merkkijono: "); // Kysytään merkkijonoa
            string input = Console.ReadLine(); // Käyttäjä antaa merkkijonon
            Console.Write("Montako merkkiä poistetaan jonon alusta ja lopusta: "); // Kysytään poistettavien kirjainten määrää
            int removal = int.Parse(Console.ReadLine()); // Käyttäjä antaa poistettavien kirjainten lukumäärän

            while (removal <= 0 || removal*2 >= input.Length) // Poistomäärän tarkistus
            {
                Console.WriteLine("Syöttämäsi luku ei saa olla nollaa pienempi tai liian suuri!"); // Virheilmoitus
                Console.Write("Montako merkkiä poistetaan jonon alusta ja lopusta: "); // Kysytään uusiksi
                removal = int.Parse(Console.ReadLine()); // Luetaan uusi syöte
            }

            int leftover = input.Length - (removal*2); // Lasketaan montako merkkiä kirjoitetaan Substring metodilla

            Console.WriteLine(input.Substring(removal,leftover)); // Tulostetaan ohjelman tuotos

            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
