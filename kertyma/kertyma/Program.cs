using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kertyma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku:");
            int numberOfRounds = int.Parse(Console.ReadLine());
            int sum = 0;

            // for-rakenteella

            for(int i = 0; i < numberOfRounds;i++)
            {
                sum += i;
            }

            Console.WriteLine($"{numberOfRounds} kierroksen kertymäksi saatiin:{sum}");
            Console.WriteLine();

            // while-rakenteella

            sum = 0;
            int round = 0;
            while (round < numberOfRounds)
            {
                sum += round;
                round++;
            }

            Console.WriteLine($"{numberOfRounds} kierroksen kertymäksi saatiin:{sum}");

            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();

        }
    }
}
