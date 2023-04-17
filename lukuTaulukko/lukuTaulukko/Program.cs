using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lukuTaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taulukko-versio
            int[] userValues = new int[3];

            Console.WriteLine("Anna 3 lukua: ");

            for(int i = 0; i < userValues.Length; i++)
            {
                userValues[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Lukujen summa on: {userValues.Sum()}");

            int sum = 0;

            for(int i = 0;i<userValues.Length;i++)
            {
                sum += userValues[i];
            }

            Console.WriteLine($"Lukujen summa on: {sum}");
            Console.WriteLine();
            Console.WriteLine("Luodaan nyt sama listalla");

            // Lista-versio

            Console.WriteLine("Syötä lukuja: ");
            List<int> values = new List<int>();
            bool userIsDone = false;
            while (userIsDone == false)
            {
                string input = Console.ReadLine();
                if (input == "e")
                {
                    userIsDone = true;
                }
                else
                {
                    values.Add(int.Parse(input));
                }
            }

            Console.WriteLine($"Listan lukujen summa on: {values.Sum()}");
            
            int sumList = 0;
            
            foreach(int number in values)
            {
                sumList += number;
            }

            Console.WriteLine($"Listan lukujen summa on: {sumList}");

            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
