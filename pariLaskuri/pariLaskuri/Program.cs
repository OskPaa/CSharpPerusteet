using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pariLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // Alustetaan laskuri 
            int increment = 2; // Alustetaan loopin lopussa lisättävä määrä
            Console.Write("Anna 0 suurempi luku:"); // Kysytään käyttäjältä luku johon asti lasketaan
            int finalNumber=int.Parse(Console.ReadLine()); // Otetaan luku syötteenä käyttäjältä
            
            while (finalNumber <= 0) //Tarkistetaan käyttäjän antama luku loopin sisällä
            {
                Console.Write("Anna 0 suurempi luku:"); // Pyydetään lukua uudestaan 
                finalNumber = int.Parse(Console.ReadLine()); // Käyttäjä antaa uuden luvun
            }

            Console.WriteLine("Tulostetaanko parilliset luvut? (k/e)"); // Kysytään kyllä/ei-vastauksella, että millaisia lukuja tulostetaan
            char pairOrNo = char.Parse(Console.ReadLine()); // Otetaan käyttäjältä vastaus

            while (pairOrNo != 'k' && pairOrNo != 'e') // Tarkistetaan käyttäjän vastaus loopissa
            {
                Console.WriteLine("Anna vastaukseksi yhtenä annetuista merkkeistä!"); // Selkeytetään, miten käyttäjän kuuluu vastata
                Console.WriteLine("Tulostetaanko parilliset luvut? (k/e)"); // Kysytään tulostuksesta uusiksi
                pairOrNo = char.Parse(Console.ReadLine()); // Otetaan käyttäjältä vastaus uusiksi
            }

            if (pairOrNo =='k') // Tapaus, jossa vastaus on kyllä
            {
                Console.WriteLine("Tulostetaan parilliset luvut!"); // Kerrotaan, mitä tulostetaan
                while (counter <= finalNumber) // Tulostus looppi
                {
                    Console.Write($"{counter}, "); // Tulostaa laskurin sen hetkisen arvon
                    counter += increment; // Nostetaan laskurin arvoa
                }
            }

            else // Tapaus, jossa vastaus on ei
            {
                Console.WriteLine("Tulostetaan parittomat luvut!"); // Kerrotaan, mitä tulostetaan
                counter = 1; // Ohitetaan parillinen luku 0 muuttamalla laskurin arvoksi 1
                while (counter <= finalNumber) // Tulostus looppi
                {
                    Console.Write($"{counter}, "); // Tulostaa laskurin sen hetkisen arvon
                    counter += increment; // Nostetaan laskurin arvoa
                }
            }

            //Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();

        }
    }
}
