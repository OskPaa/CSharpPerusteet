using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kysytään käyttäjältä kolmion korkeus
            Console.Write("Anna kolmion korkeus senttimetreinä:");
            double height = double.Parse(Console.ReadLine());

            //Kysytään käyttäjältä kolmion kanta
            Console.Write("Anna kolmion kanta senttimetreinä:");
            double stem = double.Parse(Console.ReadLine());

            //Lasketaan kolmion pinta-ala
            double area = (height * stem) / 2;

            //Ilmoitetaan laskettu pinta-ala käyttäjlle
            Console.WriteLine($"Kolmion pinta-ala on {area} neliösenttiä");

            Console.ReadKey();
        }
    }
}
