using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysytään käyttäjältä ensimmäinen luku
            Console.Write("Anna ensimmäinen luku:");
            int firstNumber = Int32.Parse(Console.ReadLine());
            
            //Kysytään käyttäjältä toinen luku
            Console.Write("Anna toinen luku:");
            int secondNumber = Int32.Parse(Console.ReadLine());
            
            //Kysytään käyttäjältä kolmas luku
            Console.Write("Anna kolmas luku:");
            int thirdNumber = Int32.Parse(Console.ReadLine());

            //Lasketaan annetujen lukujen summa, jonka jakamalla saadaan keskiarvo
            double result = (firstNumber + secondNumber + thirdNumber) / 3d;

            //Ilmoitetaan tulos käyttäjälle
            Console.WriteLine($"Antatamiesi lukujen keskiarvo on {result}.");
            
            Console.ReadKey();
        }
    }
}
