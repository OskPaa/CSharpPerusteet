using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bensanKulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            try // virheen tarkistus
            {
                decimal[] priceArray = { 0 }; // luodaan taulukko, johon matkojen hinnat tallentuvat
                int loop = 0; // Luodaan looppilaskuri
                List<decimal> priceList = new List<decimal>(); // luodaan lista, johon matkojen hinnat tallentuvat
                bool isReady = false; // luodaan boolean, jonka muuttaminen lopettaa loopin toiston
                while (!isReady)
                {

                    Console.Write("Syötä ajettava matka(km): "); // kysytään käyttäjältä matka kilometreinä
                    decimal distance = decimal.Parse(Console.ReadLine()); // otetaan matka käyttäjältä
                    Console.Write("Syötä polttoaineen kulutus(l/100km): "); // kysytään käyttäjältä keskikulutus
                    decimal gasPerHundredKm = decimal.Parse(Console.ReadLine()); // otetaan kulutus käyttäjältä
                    Console.Write("Syötä polttoaineen hinta(euro/l): "); // kysytään käyttäjältä polttoaineen hinta
                    decimal gasPrice = decimal.Parse(Console.ReadLine()); // otetaan polttoaineen hinta käyttäjältä

                    decimal price = priceOfTheTrip(distance, gasPerHundredKm, gasPrice); // tallenetaan metodilla laskettu summa  muuttujaan 
                    Console.WriteLine($"Matkakulut ovat {price} euroa"); // tulostetaan metodin laskema tulos

                    priceArray[loop] = price; // tallenetaan tulos taulukkoon
                    priceList.Add(price); // tallenetaan tulos listaan

                    Console.Write("Tehdäänkö uusi kierros(e lopettaa):"); // kysytään käyttäjältä loopin toistosta
                    string nextRound = Console.ReadLine(); // käyttäjä antaa vastauksen uudesta loopista

                    switch (nextRound)
                    {
                        case "e": // tilanteessa "e" muutetan boolean, siten että se lopettaa loopin
                            isReady = true;
                            break;
                        default: // muissa tapauksissa ennen toista looppia:
                            priceArray = biggerArray(priceArray); // laitetaan taulukko metodiin, joka kopioi sen yhtä muistipaikkaa isompana
                            loop++; // nostetaan looppilaskuria
                            break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Matkojen hinnat listalla:"); // kerrotaan, että tulostetaan listaan tallenetut tulokset
                foreach (decimal cost in priceList) // käydään lista läpi foreach loopilla
                {
                    Console.WriteLine($"{cost} euroa"); // tulostetaan listasta tieto
                }

                Console.WriteLine();
                Console.WriteLine("Matkojen hinnat taulukossa:"); // kerrotaan, että tulostetaan taulukkoon tallenetut tulokset
                foreach (decimal cost in priceArray) // käydään taulukko läpi foreach loopilla
                {
                    Console.WriteLine($"{cost} euroa"); // tulostetaan taulukosta tieto
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); // Tulostetaan virheilmoitus
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        private static decimal priceOfTheTrip(decimal distance, decimal gasPerHundredKm, decimal gasPrice) // polttoainekulut laskeva metodi
        {
            decimal result = distance / 100 * gasPerHundredKm * gasPrice; // lasketaan palautettava arvo
            return result; // palautetaan laskettu arvo
        }
        private static decimal[] biggerArray(decimal[] oldArray) // isomman listan palauttava metodi 
        {
            decimal[] newArray = new decimal[oldArray.Length+1]; // määritellään uusi lista, joka yhden muistipaikan suurempi
            int i = 0; // inkrementin määrittely
            foreach(decimal value in oldArray) // käydään tiedot vanhasta taulukosta läpi
            {
                newArray[i] = value; // tallenetaan vanhan taulukon tieto uuteen listaan
                i++; // nostetaan inkrementtiä
            }
            return newArray; // palautetaan uusi, isompi lista
        }
    }
}
