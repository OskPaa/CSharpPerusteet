using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkkiTulostus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana ja tulostus suunta (\"Lattia A\"): ");
            string word = Console.ReadLine();
            Console.Write("Montako merkkiä sanasta tulostetaan: ");
            int loops = int.Parse(Console.ReadLine());
            string[] wordSplit = word.Split(' ');

            if (wordSplit[1]=="A")
            {

            }
            else if (wordSplit[1]=="L")
            {
                char[] chars = wordSplit[0].ToCharArray();
                Array.Reverse(chars);
                string reverseWord = new string(chars);
                wordSplit[0] = reverseWord;
            }
                foreach(char mark in wordSplit[0])
                {
                    Console.WriteLine(mark);
                }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
