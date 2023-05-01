using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metriMuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters;
            try
            {
                Console.Write("Syötä metrit: ");
                meters = double.Parse(Console.ReadLine());
                Console.WriteLine($"{meters} metriä on {MeterConverter.toCentiMeter(meters)} senttimetri(ä)");
                Console.WriteLine($"{meters} metriä on {MeterConverter.toDesiMeter(meters)} desimetri(ä)");
                Console.WriteLine($"{meters} metriä on {MeterConverter.toKiloMeter(meters)} kilometri(ä)");
                Console.WriteLine($"{meters} metriä on {MeterConverter.toInch(meters)} tuuma(a)");
                Console.WriteLine($"{meters} metriä on {MeterConverter.toFeet(meters)} jalka(a)");
                Console.WriteLine($"{meters} metriä on {MeterConverter.toYard(meters)} jaardi(a)");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
