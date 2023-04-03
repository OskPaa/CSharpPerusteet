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

            // if else -rakenteella

            if (result == 1) // Jakojäännöksen ollessa 1 suoritetaan seuraava koodin pätkä 
            {
                Console.WriteLine("Luku on pariton"); // ilmoitetaan käyttäjälle luvun olevan pariton
            }
            else // Muissa tapauksissa suoritetaan seuraava koodin pätkä  
            {
                Console.WriteLine("Luku on parillinen"); // ilmoitetaan käyttäjälle luvun olevan parillinen
            }

            // switch case -rakenteella

            switch (result)
            {
                case 1:
                    Console.WriteLine("Luku on pariton");
                    break;

                default:
                    Console.WriteLine("Luku on parillinen");
                    break;
            }

            // ternary - rakenteella

            string answer = result == 1 ? "pariton" : "parillinen";  // jos result-muuttuja on 1, niin answer-muutujan arvoksi tulee "pariton". muissa tapauksissa "parillinen"  
            Console.WriteLine($"Luku on {answer}");

            //Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
