using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjausRakenne
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-rakenne

            //if condition == true
            //suoritetaan if blokin koodi

            //jos condition == false
            //hypätään koodi blokin yli

            Console.WriteLine("Ennen if");
            if(5 > 10) 
            {
                Console.WriteLine("sisällä if");
            }
            Console.WriteLine("Jälkeen if");

            Console.WriteLine();

            //if else
            //Joko suoritetaan if code block
            //Tai suoritetaan else code block

            Console.WriteLine("Ennen if");
            if ("moi" == "terve") 
            {
                Console.WriteLine("sisällä if");
            }
            else
            {
                Console.WriteLine("sisällä else");
            }
            Console.WriteLine("Jälkeen if-else");

            Console.WriteLine();

            // if - else if - else
            //  voi olla myös muita vertailuja

            Console.WriteLine("Ennen if");
            if (4.5 >= 5.5) 
            {
                Console.WriteLine("sisällä if");
            }
            else if (10 <= 20)
            {
                Console.WriteLine("sisällä else if");
            }
            else
            {
                Console.WriteLine("sisällä else");
            }
            Console.WriteLine("Jälkeen if - else if - else");

            Console.WriteLine();

            // Vertailuoperaattorit
            // Vertailujen lopputulos on totuusarvo - boolean
            // true/false
            // == samat arvot
            // != eri arvot
            // < vasen pienempi kuin oikea
            // > vasen isompi kuin vasen
            // <= vasen pienempi tai yhtä suuri kuin oikea
            // >= vasen isompi tai yhtä suuri kuin oikea

            // loogiset operaattorit
            // Voidaan yhdistää useampi vertailuoperaatio

            // && molemmat totta
            // age >= ageLimit && length == targetHeight

            // || toinen totta ctrl+alt+<
            // age >= ageLimit || length == targetHeight

            // ! kääntää totuusarvon
            // bool accountDeleted = true;
            // if(!accountDeleted)

            // Silmukat

            // while(condition)
            // {
            //  Execute done
            //  As long as condition == true
            // }

            //kommentointi ctrl + k sitten ctrl + c
            //poisto ctrl + k sitten ctrl + u

            string input = "";
            while (input != "exit")
            {
                Console.Write("Choose action:");
                input = Console.ReadLine();
                Console.WriteLine($"Executing action {input}");
            }


            // Pysäytetään sovellus
            Console.WriteLine("Press any key to end program");
            Console.ReadKey();
        }
    }
}
