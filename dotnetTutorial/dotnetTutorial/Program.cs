using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Scott";
            string secondFriend = "Kendra";
            Console.WriteLine($"Hello {firstFriend} and {secondFriend}");

            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            string greeting = "        Hello World!        ";
            Console.WriteLine($"[{greeting}]");
            
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);

            sayHello = sayHello.Replace("World", "Universe");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say greetings, and I say hello";

            bool result = songLyrics.Contains("You");

            Console.WriteLine(result);
            Console.WriteLine(songLyrics.Contains("greetings"));

            /*
            int a = 18;
            int b = 6;
            int c = a / b;
            int d = (a + b) / c;
            int e = (a + b) % c;

            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integer is {min} to {max}");

            int what = max + 3;

            Console.WriteLine($"An example of overflow: {what}");

            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;

            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;

            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal max = decimal.MaxValue;
            decimal min = decimal.MinValue;

            Console.WriteLine($"The range of decimal is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            */

            double radius = 2.50;
            double area = Math.PI * radius * radius;

            Console.WriteLine(area);

            /*
            int a = 5;
            int b = 4;

            if (a + b > 10)
            {
                Console.WriteLine("The anwer is greater than 10");
            }
            else
            {
                Console.WriteLine("The anwer is not greater than 10");
            }
            */

            int a = 5;
            int b = 3;
            int c = 4;

            if (a + b + c > 10 && a==b)
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            int counter = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }


            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3== 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"The sum is {sum}");

            List<string> names = new List<string> { "<name>", "Ana", "Felipe" };

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Felipe");

            names.Sort();

            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            int index2 = names.IndexOf("Bill");

            if(index2 == -1)
            {
                Console.WriteLine($"When an item is not found IndexOf returns {index2}");
            }
            else
            {
                Console.WriteLine($"The name {names[index2]} is at index {index2}");
            }

            List<int> fibonaciNumbers = new List<int> { 1, 1 };


            while(fibonaciNumbers.Count < 20)
            {
                int previous = fibonaciNumbers[fibonaciNumbers.Count - 1];
                int previous2 = fibonaciNumbers[fibonaciNumbers.Count - 2];
                fibonaciNumbers.Add(previous + previous2);
            }


            foreach(int item in fibonaciNumbers)
            {
                Console.WriteLine(item);
            }

            BankAccount account = new BankAccount("Kendra", 10000);

            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithDrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);


            account.MakeWithDrawal(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
            
            //try
            //{
            //    account.MakeWithDrawal(75000, DateTime.Now, "Attempt to overdraw");
            //}
            //catch(InvalidOperationException e)
            //{
            //    Console.WriteLine("Exception caught to overdraw");
            //    Console.WriteLine(e.ToString());
            //}
            
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine("Exception caught creating account with negative balance");
            //    Console.WriteLine(e.ToString());
            //}

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
