using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpKoe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Puhelinnumeron tarkistaminen

            Console.Write("Anna puhelinnumerosi: "); // Kysytään käyttäjältä puhelinnumeroa
            string phoneNumber = Console.ReadLine(); // Käyttäjä syöttää puhelinnumeron

            // Tarkistetaan ja ilmoitetaan onko annetussa numerossa oikea määrä merkkejä else if -rakenteella
            if (phoneNumber.Length == 13) // Merkkejä sopivasti
            {
                // Console.WriteLine("Numerossa on oikea määrä merkkejä."); // Kerrotaan numeron olevan sopivan pituinen 
                if (phoneNumber.StartsWith("+358")) // Tarkistetaan ovatko neljä ensimmäistä merkkiä numeron alussa oikeat
                {
                    //Console.WriteLine("Numero alkaa oikealla tavalla (+358)"); // Kerrotaan, että numeron alku on oikein

                    bool containsInvalidChar = false; // Oletetaan vakiona, että puhelinnumerossa ei ole vääriä mnerkkejä
                    int index = 4; // Aloitetaan merkkien tarkistus ideksistä 4, koska tiedetään indeksien 0-3 olevan oikein

                    while (!containsInvalidChar && index < 13) // Käydään läpi loput merkit, kunnes saavutaan loppuun tai löydetään epäkelpomerkki
                    {
                        switch (phoneNumber[index]) // Tarkistetaan, ovatko loput merkit numeroita switch casen avulla 
                        {
                            case '0':
                            case '1':
                            case '2':
                            case '3':
                            case '4':
                            case '5':
                            case '6':
                            case '7':
                            case '8':
                            case '9':
                                break;
                            default:
                                containsInvalidChar = true; // Jos löytyy väärä merkki muutetaan boolean todeksi
                                break;
                        }
                        index++; // Nostetaan indeksiä loopin seuraava kierrosta varten
                    }

                    if (containsInvalidChar)
                    {
                        Console.WriteLine("4.-13. merkin kohdalla oli epäkelpo merkki."); // ilmoitetaan käyttäjälle epäkelvon puhelinnumeron syy
                    }
                    else
                    {
                        Console.WriteLine("Puhelinnumero on kelvollinen.");
                    }
                }
                else
                {
                    Console.WriteLine("Numero  ei ala oikealla tavalla (+358)"); // ilmoitetaan käyttäjälle epäkelvon puhelinnumeron syy
                }

            }
            else if (phoneNumber.Length < 13) // Merkkejä liian vähän
            {
                Console.WriteLine("Numerossa ei ole tarpeeksi merkkejä.");
            }
            else // Merkkejä liian paljon
            {
                Console.WriteLine("Numerossa on liikaa merkkejä.");
            }
            Console.WriteLine("Press any key to clear console..."); // Tyhjennetään konsoli ennen seuraavaa osiota
            Console.ReadKey();
            Console.Clear();

            // Opiskelijan käyttäjätunnus

            Console.WriteLine($"Matti Mallikas -nimisen oppilaan käyttätunnukseksi muodostuu {GenerateStudentPassword("Matti", "Mallikas")}"); // Testi
            Console.WriteLine($"Cy Hall -nimisen oppilaan käyttätunnukseksi muodostuu {GenerateStudentPassword("Cy", "Hall")}"); // Testi

            Console.Write("Anna etunimesi: "); // kysytään käyttäjän etunimi
            string firstName = Console.ReadLine(); // käyttäjä syöttää etunimen

            Console.Write("Anna sukuunimesi: "); // kysytään käyttäjän sukunimi
            string lastName = Console.ReadLine(); // käyttäjä syöttää sukunimen

            Console.WriteLine($"Käyttäjätunnuksesi on {GenerateStudentPassword(firstName, lastName)}"); // Näytetään funktion luoma käyttäjätunnus käyttäjälle

            Console.WriteLine("Press any key to clear console..."); // Tyhjennetään konsoli ennen seuraavaa osiota
            Console.ReadKey();
            Console.Clear();

            // JavelinThrow

            List<JavelinThrow> throws = new List<JavelinThrow>(); // Luodaan lista JavelinThrow-luokan objekteille
            for (int i = 1; i < 6; i++)
            {
                Console.Write("Anna heittäjän nimi: "); // Kysytään heittäjän nimi
                string athleteName = Console.ReadLine(); // käyttäjä syötää

                Console.Write("Anna heiton metrit: "); // Kysytään heiton metrit
                int meters = int.Parse(Console.ReadLine()); // käyttäjä syötää

                Console.Write("Anna heiton senttimetrit: "); // Kysytään heiton senttimetrit
                int centimeters = int.Parse(Console.ReadLine()); // käyttäjä syötää

                throws.Add(new JavelinThrow(i, athleteName, meters, centimeters)); // Tallenetaan uusi objekti listaan
                Console.Clear();
            }

            foreach (var item in throws) // Tulostetaan listan sisältö
            {
                Console.WriteLine($"{item.Id}. heiton pituus oli {item.Meters} metriä ja {item.Centimeters} senttimetriä, jonka heitti {item.AthleteName}");
            }

            Console.WriteLine("Press any key to clear console..."); // Tyhjennetään konsoli ennen seuraavaa osiota
            Console.ReadKey();
            Console.Clear();

            // Product

            List<Product> products = new List<Product>();
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Anna tuotteen nimi: "); // Kysytään tuotteen nimi
                string productName = Console.ReadLine(); // Käyttäjä syöttää

                Console.Write("Anna tuotteen hinta: "); // Kysytään tuotteen hinta
                decimal productPrice = decimal.Parse(Console.ReadLine()); // Käyttäjä syöttää

                products.Add(new Product(i, productName, productPrice)); // Lisätään Product-objekti listaan
                Console.Clear();
            }
            Console.WriteLine("TuoteId\t\tTuotte\t\tAlennettu Hinta");
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t{item.CalculateDiscountedPrice(0.8M)}"); // Tulostetaan listan sisältö
            }
            Console.WriteLine(); // Tyhjää tilaa selkeyden vuoksi


            // Suljetaan ohjelma
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Opiskelijan käyttäjätunnus
        public static string GenerateStudentPassword(string firstName, string lastName)
        {
            string result = ""; // alustetaan palautettava string-muuttuja

            int charsToReturn = 5; // määritetään montako merkkiä palautetaan oletuksena sukunimestä
            if (lastName.Length < charsToReturn) // Tarkistetaan onko, sukunimi 5 merkkiä pienempi
            {
                charsToReturn = lastName.Length; // Määritetään palautettavien merkkien määrä uusiksi
            }
            for (int i = 0; i < charsToReturn; i++) // käydään sukunimen kirjaimia läpi for-loopissa
            {
                result += lastName[i]; // Lisätään tulokseen läpikäytävä merkki
            }

            charsToReturn = 3; // määritetään montako merkkiä palautetaan oletuksena etunimestä
            if (firstName.Length < charsToReturn) // Tarkistetaan onko, etunimi 3 merkkiä pienempi
            {
                charsToReturn = firstName.Length; // Määritetään palautettavien merkkien määrä uusiksi
            }
            for (int i = 0; i < charsToReturn; i++) // käydään etunimen kirjaimia läpi for-loopissa
            {
                result += firstName[i]; // Lisätään tulokseen läpikäytävä merkki
            }

            return result; // palautetaan tulos
        }
    }
}
