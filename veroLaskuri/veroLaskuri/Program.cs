using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veroLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna bruttopalkka: ");
            decimal grossPay = decimal.Parse(Console.ReadLine());

            Console.Write("Anna veroprosentti: ");
            decimal taxPercent = decimal.Parse(Console.ReadLine());

            (decimal, decimal) netAndTax = netPay(grossPay, taxPercent);

            Console.WriteLine($"Nettopalkka on {netAndTax.Item1}");
            Console.WriteLine($"Maksettu vero on {netAndTax.Item2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static (decimal,decimal) netPay(decimal pay,decimal tax)
        {
            (decimal, decimal) result;

            result.Item1 = (pay /100) * (100-tax);
            result.Item2 = pay - (pay / 100) * (100 - tax);

            return result;
        }
    }
}
