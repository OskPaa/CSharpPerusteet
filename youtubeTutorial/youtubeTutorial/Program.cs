using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubeTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drawing a shape
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            // Variables
            string characterName = "Tom";
            int characterAge;
            characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But he didn't like being " + characterAge);

            // Data types
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = 30;
            double gpa = 3.3;
            bool isMale = true;

            // Working with strings
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Substring(8, 3));
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase[8]);
            Console.WriteLine(phrase.Contains("Academies"));

            // Working with numbers
            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(3.2));

            // Getting user input
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            string userAge = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you're " + userAge + " years old");

            // Building a calculator
            Console.Write("Enter number:");
            double num1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter another number:");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            // Building a mad lib
            string color, pluralNoun, celebrity;
            Console.Write("Give a color: ");
            color = Console.ReadLine();
            Console.Write("Give a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Give a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");

            Console.ReadLine();
        }
    }
}
