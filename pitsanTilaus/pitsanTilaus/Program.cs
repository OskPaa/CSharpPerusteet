using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pitsanTilaus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan lista, joka sisältää vaihtoehtoina olevat täytteet
            List<Topping> allToppings = new List<Topping> { new Topping("Jauheliha"), new Topping("Pepperoni"), new Topping("Herkkusieni"), new Topping("Oliivi"), new Topping("Tonnikala") };

            Console.WriteLine("Pizzan tilaus"); // Tulostetaan otsikko
            Console.WriteLine(); // Tulostetaan tyhjää tilaa
            Console.WriteLine("Lisää haluamasi täyte syöttämällä sitä vastaava numero"); // Kysytään käyttäjältä täyte
            for(int i = 0; i < allToppings.Count; i++) // Tulostetaan täytevaihtoehdot käyttäjälle silmukassa
            {
                Console.WriteLine($"{i + 1}. {allToppings[i].Name}"); 
            }

            string input = Console.ReadLine(); // Käyttäjä tekee valintansa antamallaan syötteellä
            Pizza pizza = new Pizza(); // Alustetaan pizza objekti

            while (!input.Contains("e")) // Tarkistetaan lopetetaanko silmukka 
            {
                int inputToInteger = int.Parse(input); // Konvertoidaan syöte integeriksi
                Topping temp = allToppings[inputToInteger - 1]; // Luodaan väliaikainen objekti, johon kopioidaan tieto allToppings-listalta 
                pizza.Toppings.Add(temp); // Tallenetaan väliaikaisen objektin tieto tilauksen täytelistaan 

                Console.Clear(); // Pyyhitään käyttöliittymä tyhjäksi
                Console.WriteLine("Pizzan tilaus"); // Tulostetaan otsikko uudelleen tyhjäksi pyyhkimisen jälkeen
                Console.WriteLine(); // Tulostetaan tyhjää tilaa
                
                Console.WriteLine("Tilaamasi pizzan täytteet ovat tällä hetkellä:"); // Tulostetaan käyttäjän tilauksessa oleva ttäytteet 
                for(int i = 0; i < pizza.Toppings.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {pizza.Toppings[i].Name}");
                }
                Console.WriteLine(); // Tulostetaan tyhjää tilaa

                Console.WriteLine("Lisää haluamasi täyte syöttämällä sitä vastaava numero (e lopettaa täytteiden lisäämisen)"); // Kysytään käyttäjältä täyte
                for (int i = 0; i < allToppings.Count; i++) // Tulostetaan täytevaihtoehdot käyttäjälle silmukassa
                {
                    Console.WriteLine($"{i + 1}. {allToppings[i].Name}");
                }

                input = Console.ReadLine(); // otetaan käyttäjältä uusi syöte täytteestä/lopettamisesta
            }

            Console.WriteLine($"Tilauksesi hinta on {pizza.CalculatePrice()} euroa."); // Tulostetaan tilauksen lopullinen hinta kutsumalla Pizza-luokan metodia, joka laskee sen 

            Console.Write("Hyväksytkö tilauksesi? (k/e):"); // Pyydetään käyttäjää hyväksymään tilaus 
            string accept = Console.ReadLine();

            if (accept.Contains("k"))
            {
                Console.Write("Anna osoitteesi: "); // Käyttäjän hyväksyessä tilaus pyydetään häneltä osoite
                string address = Console.ReadLine(); // Käyttäjä syöttää osoitteensa
                Console.WriteLine($"Toimitamme pitsasi ositteeseen {address}"); // Tulostetaan viesti, joka kertoo, minne tilaus toimitetaan
            }
            else
            {
                Console.WriteLine("Tilaus peruttu.");
            }

            // Suljetaan ohjelma
            Console.WriteLine(); // Tulostetaan tyhjää tilaa
            Console.WriteLine("Press any button to quit...");
            Console.ReadKey();
        }
    }
}
