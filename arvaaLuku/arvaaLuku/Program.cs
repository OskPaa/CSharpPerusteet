using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvaaLuku
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 13; // määritellään arvattava luku
            bool correctGuess = false;
            while (correctGuess == false)
            {
                Console.Write("Koita arvata salainen luku:");
                int guess = int.Parse(Console.ReadLine());
                if (guess == secretNumber)
                {
                    Console.WriteLine("Arvasit oikein");// oikea arvaus
                    correctGuess = true;
                }

                else if (guess < secretNumber)
                {
                    Console.WriteLine("Arvauksesi on liian pieni.");// liian pieni arvaus
                }

                else
                {
                    Console.WriteLine("Arvausesi on liian iso.");// liian suuri arvaus
                }
            }

            //suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();

        }
    }
}
