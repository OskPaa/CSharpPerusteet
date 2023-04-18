using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funktioHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5,8,6,100};
            Console.WriteLine(arrayAverage(numbers));
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
        private static double arrayAverage(int[] numArray)
        {
            double sum=0;
            int count =0;
            foreach (int number in numArray)
            {
                sum += number;
                count++;
            }
            return sum/count;
        }
    }
}
