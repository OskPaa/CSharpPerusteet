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
        public string Species { get; set; }

        public string Name { get; set; }

        public char Gender { get; set; }

        public double Weight { get; set; }

        public int Age { get; set; }

        public bool Vaccinated { get; set; }

        // Consrtuctor
        public Animal(string aSpecies,string aName, char aGender, double aWeight, int aAge)
        {
            Species = aSpecies;
            Name = aName;
            Gender = aGender;
            Weight = aWeight;
            Age = aAge;
            Vaccinated = false;
        }

        // Method(s)
        public void Vaccinate()
        {
            if (Vaccinated)
            {
                Console.WriteLine($"{Species} nimeltään {Name} on jo rokotettu.");
            }
            else
            {
                Vaccinated = true;
                Console.WriteLine($"{Species} nimeltään {Name} on nyt rokotettu.");
            }

        }
    }
}
