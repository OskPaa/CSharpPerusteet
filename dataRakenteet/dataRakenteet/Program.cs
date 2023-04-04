using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataRakenteet
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Sanajono";

            // Foreach-metodi merkkijonolle

            foreach (char mark in word)
            {
                Console.WriteLine(mark);
            }

            // Foreach-metodi taulukolle

            int[] numbers = { 1, 2, 3 };
            foreach (int number in numbers)
            {
                Console.Write($"{number},");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
