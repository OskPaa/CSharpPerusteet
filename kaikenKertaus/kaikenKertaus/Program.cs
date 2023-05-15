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
            
            do // Lisätään loopissa ainakin  1 eläin
            {
                Console.Write("Anna eläimen laji: "); // Kysytään eläimen laji käyttäjältä
                string species = Console.ReadLine();

                Console.Write("Anna eläimen nimi: "); // Kysytään eläimen nimi käyttäjältä
                string name = Console.ReadLine();

                Console.Write("Anna eläimen sukupuoli(F/M): "); // Kysytään eläimen sukupuoli käyttäjältä
                string genderString = Console.ReadLine();
                char gender = genderString[0];

                Console.Write("Anna eläimen paino(kg): "); // Kysytään eläimen paino käyttäjältä
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Anna eläimen ikä: "); // Kysytään eläimen ikä käyttäjältä
                int age = int.Parse(Console.ReadLine());

                // Luodaan ja lisätään listaan Animal-luokan objekti käyttäjän antamilla tiedoilla 
                animals.Add(new Animal(species,name,gender,weight,age));

                Console.Write("Lisätäänkö vielä eläimiä?(k jatkaa): "); // Kysytään, jatketaanko eläinten lisäämistä
                contLoop = Console.ReadLine(); // Käyttäjä päättää/vastaa, jatketaanko eläinten lisäämistä

            } while (contLoop.Contains("k")); // Tarkistetaan loopin lopussa, jatkuuko eläimien lisäys

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Laji\tNimi\tSukupuoli\tPaino\tIkä\tRokotettu"); // Kirjoitetaan otsikot tulostettaville tiedoille
            foreach(var item in animals)
            {
                // Tulostetaan listaan tallennetun objektin tiedot omalle rivilleen
                Console.WriteLine($"{item.Species}\t{item.Name}\t{item.Gender}\t\t{item.Weight}\t{item.Age}\t{item.Vaccinated}"); 
            }


            // Rokotetaan satunnaisia eläimiä for-loopissa
            Console.ForegroundColor = ConsoleColor.White;
            Random random = new Random(); // Satunnaisten lukujen luomiseksi tehdään Random-luokan objekti

            for(int i = 0; i < animals.Count; i++)
            {
                animals[random.Next(i, animals.Count)].Vaccinate(); // Rokotetaan satunnainen eläin
            }


            // Tallenetaan rokotetut eläimet taulukkoon
            Animal[] vaxAnimals = GetHealthyAnimals(animals);
            Console.ForegroundColor = ConsoleColor.Blue;
            if (vaxAnimals.Length > 0) // Katsotaan onko taulukossa yhtään rokotettua eläintä 
            {
                foreach(var item in vaxAnimals)
                {
                    Console.WriteLine($"{item.Name} on rokotettu."); // Tulostettaan, minkä niminen eläinj on rokotettu
                }            
            }
            else 
            {
                // Tulostetaan ilmoitus, jossa kerrotaan ettei rokotettuja eläimiä ole
                Console.WriteLine("Taulukko ei sisällä yhtään rokotettua eläintä.");  
            }

            Console.ForegroundColor = ConsoleColor.White;
            // Suljetaan ohjelma
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static Animal[] GetHealthyAnimals(List<Animal> animals)
        {
            int vaxCount = 0;
            
            foreach(var item in animals) // Lasketaan loopissa rokotetut eläimet listalta
            {
                if (item.Vaccinated)
                {
                    vaxCount++;
                }
            }

            Animal[] result = new Animal[vaxCount]; // Luodaan sopivan kokoinen lista palautettavaksi
            int arrayIndex = 0; // Luodaan laskuri taulukon indeksointia varten

            foreach (var item in animals) // Taulukoidaan rokotettut eläimet loopissa
            {
                if (item.Vaccinated)
                {
                    result[arrayIndex] = item;
                    arrayIndex++;
                }
            }

            return result; // Palautetaan taulukko
        }
    }
}
