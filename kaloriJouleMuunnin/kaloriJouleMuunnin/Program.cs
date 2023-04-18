using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaloriJouleMuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä kovertoitava luku: ");
            double convert = double.Parse(Console.ReadLine());
            string choice = "no";
            while (choice!="c" && choice!="j") 
            {
                Console.Write("Kaloreiksi (c) vai jouleiksi (j)");
                choice = Console.ReadLine();
            }
            double result = 0;
            switch (choice)
            {
                case "c":
                    result = joulesToCalories(convert);
                    Console.WriteLine($"{convert} joulea on {result} kaloria");
                    break;
                case "j":
                    result = caloriesToJoule(convert);
                    Console.WriteLine($"{convert} kaloria on {result} joulea");
                    break;
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static double caloriesToJoule(double c)
        {
            return c * 4.184;
        }

        private static double joulesToCalories(double j)
        {
            return j * 0.2390;
        }
    }
}
