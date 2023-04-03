using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lampomuunnin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitä lämpöyksikköä tahdot muuttaa toiseksi? Anna vastauksesi yhtenä merkkinä!"); // Kysytään käyttäjältä kovertoitavaa yksikköä
            Console.Write("Farenheit(f) / Celsius(c):"); // Näytetään, miten valinta tehdään
            
            double temperature; // Alustetaan syötettävä lämpötila
            double celsius; // Alustetaan laskettava celsius-lämpötila
            double farenheit; // Alustetaan laskettava farenheit-lämpötila

            int firstCoversionValue = 32; // Määritellään konvertoinnissa käytettäviä arvoja
            int secondConversionValue = 5; // Määritellään konvertoinnissa käytettäviä arvoja
            int thirdConversionValue = 9; // Määritellään konvertoinnissa käytettäviä arvoja
            
            char choice = char.Parse(Console.ReadLine()); // Käyttäjä syöttää valintansa
            
            while (choice != 'c' && choice != 'f') // Tarkistetaan, antoiko käyttäjä oikean syötteen. Looppi ei lopu ennen sopivaa syötettä
            {
                Console.Write("Vastaa joko merkillä f tai c!"); // Pyydetään käyttäjältä oikeanlaista syötettä
                choice = char.Parse(Console.ReadLine());// Käyttäjä syöttää valintansa
            }
            
            Console.Write($"Anna lämpötila({choice}):"); // Kysytään käyttäjältä muunnettava lämpötila
            temperature = double.Parse(Console.ReadLine()); // Käyttäjä syöttää muunnettavan lämpötilan

            if (choice == 'c') // Käyttäjän valitessa c:n suoritetaan koodin pätkä
            {
                farenheit = temperature * thirdConversionValue / secondConversionValue + firstCoversionValue; // Lasketaan lämpö farenheitina
                Console.WriteLine($"{temperature} celsiusta on {farenheit} farenheitia."); // ilmoitetaan lämpö farenheitina
            }
            else // Käyttäjän valitessa f:n suoritetaan koodin pätkä.(loopista ei voi edetä muilla arvoilla kuin c:llä ja f:llä)
            {
                celsius = temperature - firstCoversionValue; // Lasketaan lämpö celsiuksena
                celsius *= secondConversionValue; // Lasketaan lämpö celsiuksena
                celsius /= thirdConversionValue; // Lasketaan lämpö celsiuksena
                Console.WriteLine($"{temperature} farenheitia on {celsius} celsiusta."); // ilmoitetaan lämpö celsiuksena
            }

            // Suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
