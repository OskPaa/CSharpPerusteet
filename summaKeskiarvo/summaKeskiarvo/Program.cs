using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summaKeskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna laskettavien lukujen määrä:");
            int loops = int.Parse(Console.ReadLine());

            double sum = 0;

            for(int i = 0; i < loops; i++)
            {
                Console.Write("Anna luku:");
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }

            double average = sum / loops;

            Console.WriteLine($"Lukujesi summa on {sum} ja niiden keskiarvo on {average}");
            Console.WriteLine();
            Console.WriteLine("Press any button to close program");
            Console.ReadKey();
        }
    }
}
