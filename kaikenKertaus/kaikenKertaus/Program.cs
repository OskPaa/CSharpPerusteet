using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaikenKertaus
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>(); // Luodaan Animal-luokan objekteille lista
            string contLoop = "";
            
            do //Lisätään loopissa eläimiä
            {
                Console.Write("Anna eläimen laji: ");
                string species = Console.ReadLine();

                Console.Write("Anna eläimen nimi: ");
                string name = Console.ReadLine();

                Console.Write("Anna eläimen sukupuoli(F/M): ");
                string genderString = Console.ReadLine();
                char gender = genderString[0];

                Console.Write("Anna eläimen paino(kg): ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Anna eläimen ikä: ");
                int age = int.Parse(Console.ReadLine());

                // Lisätään listaan Animal-luokan objekti
                animals.Add(new Animal(species,name,gender,weight,age));

                Console.Write("Lisätäänkö vielä eläimiä?(k jatkaa): ");
                contLoop = Console.ReadLine();

            } while (contLoop.Contains("k"));

            Console.WriteLine("Laji\tNimi\tSukupuoli\tPaino\tIkä\tRokotettu");
            foreach(var item in animals)
            {
                Console.WriteLine($"{item.Species}\t{item.Name}\t{item.Gender}\t\t{item.Weight}\t{item.Age}\t{item.Vaccinated}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public Animal[] GetHealthyAnimals()
        {
            Animal[] result = new Animal[0];
            return result;
        }
    }
}
