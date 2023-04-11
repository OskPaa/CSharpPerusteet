using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 12d;
            int loops = 4;
            for(int i = 1; i <= loops; i++)
            {
                switch (i)
                {
                    case 1:
                        initialValue += i;
                        break;
                    case 2:
                        initialValue *= i;
                        break;
                    case 3:
                        initialValue /= i;
                        break;
                    case 4:
                        initialValue -= i;
                        break;
                }
            }
            Console.WriteLine(initialValue);
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
