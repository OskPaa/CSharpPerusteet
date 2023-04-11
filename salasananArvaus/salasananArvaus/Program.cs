using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salasananArvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "apina"; // luodaam salasana
            Console.Write("Arvaa salasana:"); // kysytään salasanaa
            string guess = Console.ReadLine(); // käyttäjä antaa salasanan
            bool passwordCorretct = false; // määritetään totuusarvo while-silmukkaa varten

            while (passwordCorretct == false) // Looppi, joka pyörii niin kauan kuin totuusarvo on false
            {
                if (guess == password) // Tarkistetaan onko salasana oikein
                {
                    Console.WriteLine("Salasana oikein!"); // ilmoitetaan oikeasta arvauksesta
                    passwordCorretct = true; // muutetaan totuusarvo todeksi
                }
                else // Tilanne, jossa salasanaa ei arvattu oikein
                {
                    Console.WriteLine("Salasana väärin!"); // ilmoitetaan väärästä arvauksesta
                    Console.Write("Arvaa salasana uudestaan:"); // pyydetään salasanaa käyttäjältä uudestaan
                    guess = Console.ReadLine(); // Luetaan käyttäjän uusi arvaus salasanasta
                }
            }
                // Suljetaan ohjelma
                Console.WriteLine();
                Console.WriteLine("Press any key to close program");
                Console.ReadKey();
        }
    }
}
