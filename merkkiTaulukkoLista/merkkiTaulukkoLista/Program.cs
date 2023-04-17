using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkkiTaulukkoLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sana: "); // Kysytään käyttäjältä tulostettava sana
            string word = Console.ReadLine(); // Otetaan käyttäjältä tulostettava sana

            char[] charArray = new char[word.Length]; // Luodaan sanalle sopiva taulukko
            List<char> charList = new List<char>(); // Luodaan sanaa varten lista

            int i = 0; // Luodaan loopille inkrementti
            foreach(char letter in word) // foreach looppi, joka käy sanasta kaikki kirjaimet läpi
            {
                charArray[i] = letter; // Lisätään merkki taulukkoon
                charList.Add(letter); // Lisätään merkki listaan
                i++; // Nostetaan ikrementtiä
            }

            foreach(char letter in charArray) // foreach looppi, joka käy taulukosta kaikki kirjaimet läpi
            {
                if (letter % 2 != 0) // Tarkistetaan onko, kirjain parillinen
                {
                    Console.Write((char)(letter - 32)); // Tässä tapauksessa kirjoitetaan isolla
                }
                else
                {
                    Console.Write(letter); // Tässä tapauksessa kirjoitetaan pienellä 
                }
            }

            Console.WriteLine();

            foreach (char letter in charList) // foreach looppi, joka käy listasta kaikki kirjaimet läpi
            {
                if (letter % 2 != 0) // Tarkistetaan onko, kirjain parillinen
                {
                    Console.Write(letter); // Tässä tapauksessa kirjoitetaan pienellä
                }
                else
                {
                    Console.Write((char)(letter - 32)); // Tässä tapauksessa kirjoitetaan isolla
                }
            }

            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
