using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmioFunktio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna kolmion kanta: ");
            double stem = double.Parse(Console.ReadLine());
            Console.Write("Anna kolmion korkeus: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kolmion pinta-ala on {triangle(stem, height)}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static double triangle(double a, double h)
        {
            return a*h/2;
        } 
    }
}
