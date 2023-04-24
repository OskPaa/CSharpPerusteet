using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youtubeTutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buiding a guessing game
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }

            // For loops
            int[] luckyNumbers = { 4,8,15,16,23,42};
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            // BuildinG an exponent method
            Console.WriteLine(getPow(3,2));

            // 2d arrays
            int[,] numberGrid = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] myArray = new int[2,3];
            Console.WriteLine(numberGrid[1, 1]);

            // Comments

            // This is one line comment
            /*
             This
            is
            multi
            line
            comment
             */

            // Exception handling

            try
            {
                Console.Write("Enter number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            /*finally
            {

            }*/

            // Classes and objects

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of The Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book2.title);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // BuildinG an exponent method
        static int getPow(int baseNum,int powNum)
        {
            int result =1;
            for(int i=0; i < powNum;i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
