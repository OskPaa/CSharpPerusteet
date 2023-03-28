using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikaTarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; // Alustetaan muuttuja, johon käyttäjän syöte tallenetaan 
            int minAge = 0; // Määritellään minimi ikä
            int maxAge = 120; // Määritellään maksimi ikä
            bool answer = false; // Määritellään vastauksen totuusarvo epätodeksi

            while (answer == false)
            {
                Console.Write("Anna ikäsi:");//Kysytään käyttäjältä tämän ikä

                age = int.Parse(Console.ReadLine());//Käyttäjä antaa ikänsä

                if (age >= minAge && age <= maxAge) 
                {
                    Console.WriteLine("Syöttämäsi ikä vaikuttaa järkevälle."); // Kerrotaan käyttäjälle, että syöte hyväksytään
                    answer = true; // Tehdään vastauksesta tosi
                }

                else
                {
                    Console.WriteLine("Syöttämäsi ikä ei ole uskottava."); // Kerrotaan, että käyttäjä ei syöttänyt sopivaa ikää 
                    Console.WriteLine($"Anna joku järkevä ikä ({minAge}-{maxAge})."); // Kehotetaan käyttäjää syöttämään ikä joka kelpaa sovellukselle 
                }
            }

            //Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();

        }
    }
}
