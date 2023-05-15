using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaikenKertaus
{
    class Animal
    {
        // Properties
        public string Species { get; set; } // Eläimen laji

        public string Name { get; set; } // Eläimen nimi

        public char Gender { get; set; } // Eläimen sukupuoli

        public double Weight { get; set; } // Eläimen paino

        public int Age { get; set; } // Eläimen ikä

        public bool Vaccinated { get; set; } // Onko eläin rokotettu

        // Consrtuctor
        public Animal(string aSpecies,string aName, char aGender, double aWeight, int aAge)
        {
            Species = aSpecies;
            Name = aName;
            Gender = aGender;
            Weight = aWeight;
            Age = aAge;
            Vaccinated = false; // Eläin on luontihetkellä rokottamaton
        }

        // Method(s)
        public void Vaccinate()
        {
            switch (Vaccinated)
            {
                case true:
                    Console.WriteLine($"{Species} nimeltään {Name} on jo rokotettu."); // Ilmoitetaan rokotettavan eläimen olevan jo valmiiksi rokotettu
                    break;
                default:
                    Vaccinated = true; // Rokotetaan eläin
                    Console.WriteLine($"{Species} nimeltään {Name} on nyt rokotettu."); // Ilmoitetaan eläimen olevan rokotettu
                    break;
            }

        }
    }
}
