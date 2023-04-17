using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaMerkkiVertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna ensimmäinen sana: "); // Kysytään sanaa käyttäjältä
            string word1 = Console.ReadLine(); // Luetaan käyttäjältä sana
            Console.Write("Anna toinen sana: "); // Kysytään toista sanaa käyttäjältä
            string word2 = Console.ReadLine(); // Luetaan käyttäjältä sana
            
            List<(char, int)> charsInCommon = new List<(char, int)>(); // Luodaan lista

            int round = 0; // Luodaan looppi/kierros laskuri
            string charTest = ""; // Luodaan merkkijono tarkistusta varten, ettei sama merkki toista useasti samassa listassa

            foreach(char word1Letter in word1) // Uloin foreach-looppi joka käy ensimmäisen sanan kirjaimet läpi
            {
                int listCounter = 0; // Luodaan laskuri kirjaimille ja nollataan se joka kierroksen alussa
                foreach (char word2Letter in word2) // Sisäinen foreach-looppi, joka käy toisen sanan kirjaimet läpi
                {
                    if(word1Letter == word2Letter && charTest.Contains(word1[round]) == false) // Tarkistetaan ovatko merkit samalaisia ja onko samaa kirjainta käyty jo läpi
                    {
                        listCounter++; // Nostetaan kirjainlaskurin arvoa
                        if (charsInCommon.Contains((word1Letter,listCounter - 1))) // Tarkistetaan onko listan sisällä toistuvia kirjaimia
                        {
                            charsInCommon.Remove((word1Letter, listCounter - 1)); // Poistetaan aiempi ilmentymä kirjaimesta listalta 
                        }
                        charsInCommon.Add((word1Letter,listCounter)); // lisätään listaan uusi muuttuja
                    }
                }
                charTest += word1Letter; // Lisätään tarkistavaan merkkijonoon merkki
                round++; // Nostetaan kierroslaskuria
            }

            foreach ((char c, int i) in charsInCommon) // Käydään valmis lista läpi foreach-loopilla
            {
                Console.WriteLine($"Merkki {c} oli toisessa sanassa {i} kertaa"); // Tulostetaan listan arvot
            }

            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
