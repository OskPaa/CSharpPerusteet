using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackeysTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1 Basics
            
            // Muutetaan ulkoasua
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            // Keskustelua konsolin ja käyttäjän välillä
            Console.WriteLine("Hello, what's your name?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("My name is RX-9000.");
            Console.Write("I am an AI sent from the future to ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DESTROY MANKIND.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is your favorite color?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Cool! Mine is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DESTRUCTION.");
            Console.ForegroundColor = ConsoleColor.White;

            // #2 Variables

            Console.WriteLine("\nWhat is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, nice to meet you!");

            double num01;
            double num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            double result = num01 * num02;
            Console.WriteLine($"The result is {result}");

            // #3 Conditions

            Console.WriteLine("\nWelcome! Tickets are 5$. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if(cash < 5)
            {
                Console.WriteLine("That's not enough money.");
            }
            else if(cash == 5)
            {
                Console.WriteLine("Here is your ticket.");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine($"Here is your ticket and {change} dollars in change.");
            }

            int age;
            int height;

            Console.Write("\nPlease input your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input your height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if(age >= 18 || height >= 160)
            {
                Console.WriteLine("You can enter!");
            }
            else
            {
                Console.WriteLine("You don't meet the requirements.");
            }

            Console.Write("\nInput a number between 1 and 5: ");
            int num = Convert.ToInt32(Console.ReadLine()); ;

            switch (num)
            {
                case 1: Console.WriteLine("One");break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                default: Console.WriteLine("Default"); break;
            }

            // #4 Loops

            Console.Write("\nHow many cool numbers do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }

            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("\nPress enter to roll the die.");

            while (roll != 6)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine($"\nYou rolled: {roll}");
                attempts++;
            }

            Console.WriteLine($"It took you {attempts} attempts to roll a six.");

            // #5 Arrays

            string[] movies = { "Lord of the Rings", "Fight Club", "Interstellar", "Gladiator"};
            Array.Sort(movies);
            Console.WriteLine("Here are four movies arranged alpahabetically.");
            for(int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine($"{rank}. {movies[i]}");
            }

            List<string> shoppingList = new List<string>();
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                int rank = i + 1;
                Console.WriteLine($"{shoppingList[i]}");
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("---------------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                int rank = i + 1;
                Console.WriteLine($"{shoppingList[i]}");
            }

            // #6 Methods

            MeetAlien();
            Console.WriteLine("---------------------------");
            MeetAlien();

            int multiply = Multiply(3, 8);

            Console.WriteLine($"The result is {multiply}");

            if (multiply % 2 == 0)
            {
                Console.WriteLine($"{multiply} is an even number.");
            }
            else
            {
                Console.WriteLine($"{multiply} is an uneven number.");
            }

            // #7 Classes

            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");

            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);

            // Suljetaan ohjelma
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        // #6 Methods
        static void MeetAlien()
        {
            Random numGen = new Random();

            string name = $"X-{numGen.Next(10, 9999)}";
            int age = numGen.Next(10, 500);
            Console.WriteLine($"My name is{name}.");
            Console.WriteLine($"I am {age} years old.");
            Console.WriteLine("Oh, also I'm an alien.");
        }

        static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }
    }
    // #7 Classes
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;
            
            Count++;
        }

        public void CastSpell()
        {
            if(spellSlots > 0)
            {
                Console.WriteLine($"{name} casts {favoriteSpell}");
                spellSlots--;
                experience += 0.3f;
            }
            else
            {
                Console.WriteLine($"{name} is out of spell slots");
            }
        }
        public void Meditate()
        {
            Console.WriteLine($"{name} meditates to regain spell slots");
            spellSlots = 2;
        }
    }
}
