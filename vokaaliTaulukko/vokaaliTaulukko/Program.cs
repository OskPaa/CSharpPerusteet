using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vokaaliTaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna sana: ");
            string word = Console.ReadLine();
            char[] vowels = new char[word.Length]; // Luodaan taulukko
            List<char> vowelList = new List<char>(); // Luodaan lista

            int i = 0; // Tehdään inkrementti looppia varten 
            foreach (char letter in word) // Käydään merkkijonon kirjaimet foreach loopissa
            {
                switch (letter) // Tutkitaan kirjaimet switch case -valintarakenteella
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                    case 'ä':
                    case 'ö':
                        vowelList.Add(letter); // Lisätään vokaali listaan
                        vowels[i] = letter; // Lisätään vokaali taulukkoon
                        i++; // Nostetaan inkrementtiä
                        break; // Päätetään switch case
                }
            }
            // Tulostetaan taulukon sisältä foreach-loopilla
            foreach(char vowel in vowels)
            {
                if (vowel != 0) 
                { 
                    Console.Write(vowel);
                }
            }
            Console.WriteLine();
            // Tulostetaan listan sisältä foreach-loopilla
            foreach (char vowel in vowelList)
            {
                Console.Write(vowel);
            }
            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
