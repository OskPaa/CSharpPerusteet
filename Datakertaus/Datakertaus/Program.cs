using System;

namespace Datakertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kerrotaan käyttäjälle, mitkä muuttujat luodaan ja mitkä niiden arvot ovat.
            Console.WriteLine("Luodaan muuttujia eri datatyypeillä");
            
            int kuukaudet = 12;
            Console.WriteLine($"{kuukaudet} - ilmaisee kuukausien määrän vuodessa!");
            
            char valuutta = '€';
            Console.WriteLine($"{valuutta} - ilmaisee Euroopassa käytettävän rahayksikön!");
            
            double pii = 3.14;
            Console.WriteLine($"{pii} - ilmaisee piin arvon kahden desimaalin tarkkuudella!");

            string marja = "mustikka";
            Console.WriteLine($"{marja} - ilmaisee  tumman marjan nimen!");

            //Kerrotaan käyttäjälle, että muuttujien arvot muutetaan.
            Console.WriteLine("Annetaan muuttujille eri arvot");

            kuukaudet = 6;
            Console.WriteLine($"{kuukaudet} - ilmaisee kuukausien määrän puolessa vuodessa!");

            valuutta = '$';
            Console.WriteLine($"{valuutta} - ilmaisee Amerikassa käytettävän rahayksikön!");

            pii = 3.14159;
            Console.WriteLine($"{pii} - ilmaisee piin arvon viiden desimaalin tarkkuudella!");

            marja = "mansikka";
            Console.WriteLine($"{marja} - ilmaisee punaisen marjan nimen!");
        }
    }
}
