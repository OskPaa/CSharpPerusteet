using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna kokonaisluku:");//Kysytään käyttäjältä kokonaislukua
            
            int numberInput = int.Parse(Console.ReadLine()); //Otetaan luku syötteenä käyttäjältä

            if (numberInput == 0) //Katsotaan onko luku nolla. Jos on, suoritetaan koodi hakasulkeiden koodin pätkä
            {
                Console.WriteLine("Lukusi on 0.");//Ilmoitetaan, että luku on nolla
            }

            else if (numberInput > 0) //Jos luku ei ollut nolla katsotaan, onko se nollaa suurempi. Jos on, suoritetaan koodi hakasulkeiden koodin pätkä  
            {
                Console.WriteLine("Lukusi on nollaa suurempi.");//Ilmoitetaan luvun olevan nollaa suurempi
            }

            else //Muussa tapauksessa suoritetaan seuraavissa hakasulkeissa oleva koodin pätkä
            {
                Console.WriteLine("Lukusi on nollaa pienempi.");//Ilmoitetaan luvun olevan nollaa pienempi
            }

            //Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
