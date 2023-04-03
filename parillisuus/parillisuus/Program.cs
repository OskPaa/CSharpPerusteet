using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parillisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku:");
            int value = int.Parse(Console.ReadLine());
            int result = value % 2; // Selvitetään onko luvulla jakojäännös, kun se jaetaan kahdella
            if (result == 1) // Jakojäännöksen ollessa 1 suoritetaan seuraava koodin pätkä 
            {
                Console.WriteLine("Luku on pariton"); // ilmoitetaan käyttäjälle luvun olevan pariton
            }
            else // Muissa tapauksissa suoritetaan seuraava koodin pätkä  
            {
                Console.WriteLine("Luku on parillinen"); // ilmoitetaan käyttäjälle luvun olevan parillinen
            }

            //Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
