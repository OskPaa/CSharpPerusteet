using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkkiVertailu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna eka merkkijono: ");
            string word1 = Console.ReadLine();
            
            Console.Write("Anna toinen merkkijono: ");
            string word2 = Console.ReadLine();

            (char charValue, int intValue)[] charsInCommon = new (char, int)[word1.Length];

            string charsTested = "";

            for (int i = 0; i < word1.Length; i++)
            {
                int numberOfTimesFound = 0;

                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j] && charsTested.Contains(word1[i]) == false) 
                    {
                        numberOfTimesFound++;
                        charsInCommon[i] = (word1[i], numberOfTimesFound);
                    }
                }
                charsTested += word1[i];
            }

            foreach ((char,int) pair in charsInCommon)
            {
                Console.WriteLine($"Merkki {pair.Item1} löytyi {pair.Item2} kerran/kertaa");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();

        }
    }
}
