using System;

namespace Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koodi tulee tähän
            // syntax - syntaksi
            // tämä on kommentti
            // se ei suorita mitään

            // datatyypit
            // numeroita

            // 35 on kokonaisluku - integer
            // 13.5 liukuluku - floating point

            // merkkejä -char
            // merkkijonoja -string
            // 't' / "word"
            // Bool
            // true/false 1/0
            // literals
            // data tallessa muuttujissa
            //<data type> <variable name>

            //int
            int apu = 5;
            int integerValue = 10; // puolipiste rivin loppuun
            integerValue = 15; //annetaan muuttujalle uusi arvo
            //double
            double doubleValue = 3.14;

            // char
            char characterValue = 'r';
            // string
            string stringValue = "Word";
            // bool
            bool boolValue = false;

            // kommunikointi sovelluksen kanssa
            // käyttäjänä
            
            //string message = "Hello! ";
            string answer = Console.ReadLine();
            Console.WriteLine("Hello {0}!", answer);
            Console.WriteLine($"{answer} voi jatkaa tekstiä");

            #region 3 C# Perus: Ikä-tehtävä 
            //Kysytään käyttäjältä hänen ikänsä
            Console.WriteLine("Hei! Kerro Minulle ikäsi!");
            //Käyttäjä syötää ikänsä
            int ika = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Olet {ika} vuotta!");
            //Lasketaan käyttäjän ikä kuukaisina
            int kuukausina = ika * 12;
            // ilmoitetaan käyttäjän ikä kuukaisina
            Console.WriteLine($"Olet siis {kuukausina} kuukautta vanha!");
            #endregion

            #region 4 C# Perus: Palkan lasku
            //kysytään työntekijän palkka
            Console.WriteLine("Anna työntekijän tuntipalkka euroina");
            //käyttäjä syöttää tuntipalkan
            double palkka = double.Parse(Console.ReadLine());
            //kysytään työntekijän normaalipalkkaiset tunnit
            Console.WriteLine("Anna työntekijän normaalipalkkaiset tunnit");
            //käyttäjä syöttää normaalipalkkaiset tunnit
            int tunnit = Int32.Parse(Console.ReadLine());
            //kysytään työntekijän 50% koron tunnit
            Console.WriteLine("Anna työntekijän 50% korotetut tunnit");
            //käyttäjä syöttää 50% koron tunnit
            int korkotunnit50 = Int32.Parse(Console.ReadLine());
            //kysytään työntekijän 100% koron tunnit
            Console.WriteLine("Anna työntekijän 100% korotetut tunnit");
            //käyttäjä syöttää 100% koron tunnit
            int korkotunnit100 = Int32.Parse(Console.ReadLine());
            #endregion
        }
    }
}
