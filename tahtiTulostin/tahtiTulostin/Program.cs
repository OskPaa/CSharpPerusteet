using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahtiTulostin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Montako merkkiä tulostetaan?:");
            int numberToPrint = int.Parse(Console.ReadLine());

            Console.Write("Anna tulostettava merkki:");
            char input = char.Parse(Console.ReadLine());

            for (int i = 0; i < numberToPrint; i++)
            {
                Console.Write(input);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
