using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubeTutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            
            int[] luckuNumbers = { 4, 8, 15, 16, 23, 42 };
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckuNumbers[1] = 900;
            Console.Write( luckuNumbers[1] );

            // Methods
            
            SayHi("Mike",33);
            SayHi("John",56);
            SayHi("Tom",12);

            // Return statements
            
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            // If statements
            
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            Console.WriteLine(getMax(10, 20,30));

            // Buiding a better calculator
            
            Console.Write("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = double.Parse(Console.ReadLine());

            if(op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            // Switch statements

            Console.WriteLine(getDay(0));

            // While loops

            int index = 1;

            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            index = 6;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }

        // Methods
        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age}");
        }

        // Return statements

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        // if statements
        static int getMax(int num1,int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }

        // Switch statements
        static string getDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }
    }
}
