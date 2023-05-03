using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondSymbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecondSymbol("Hello world!!", 'l'));
            Console.ReadKey();
        }
        public static int SecondSymbol(string str, char symbol)
        {
            int foundInstances = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    if (foundInstances < 1)
                    {
                        foundInstances++;
                        Console.WriteLine(foundInstances);
                    }
                    else
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
