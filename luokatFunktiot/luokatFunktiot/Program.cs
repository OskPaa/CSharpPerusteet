using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luokatFunktiot
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Funktio / Function
            #region
            // Funktio on keino kapsuloida tietty toiminnallisuus, jota vouidaan käyttää uudelleen eri kohdissa projektia

            // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti
            // Metodi on termi funktiolle, joka on osana luokkaa

            // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen funktioon / metodiin "Main"

            // Funktion / Metodi koodi tulee tiettyyn kohtaan tiedostoa

            // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle muiden metodien ja funktioiden kanssa luokan sisälle

            // Tämä ei voi luoda uutta funktiota, koska olemme jo "Main"-funktion sisällä
            // Metodi luotiin "Main"-funktion alapuolelle

            // Täällä voidaan käyttää metodia

            // UUSI TERMI: olio / object
            // olio on instanssi luokasta
            // Oletuksena metodeja voi ainoastaan käyttää, ellei luoda luokasta on luotu objekti
            // Nyt uutta "PrintText()"-metodia ei voida käyttää ellei luoda luokasta "Program" uutta objektia

            Program test = new Program(); // Luodaan tämän tiedoston "Program" luokasta objekti
            test.printText("Hello",123);
            test.printText("World", 321);

            // Poikkeuksena staattinen metodi
            // Jos metodista luodaan staattinen, sitä voi käyttää suoraan ilman objektia

            // Esim.
            Console.WriteLine(""); // Tämä on "Console"-luokan staattinen "WriteLine"-metodi
            // Program.multiplyNumbers(5,3); // Viittaus "Program" luokkaan ei ole pakollinen koska olemme jo sen sisällä
            int fivetimesthree = multiplyNumbers(5,3); // metodi palauttaa arvon, se pitää ottaa talteen
            // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa
            // Nyt multiplyNumbers() palautettava arvo toimii metodille "WriteLine"
            Console.WriteLine(multiplyNumbers(5, 3));

            #endregion
            // 2.Luokka / Class
            #region



            #endregion
            // 3.struct


            // 4.enum
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Luodaan uusi metodi, muiden  metodien ulkopuolelle, mutta luokan sisälle

        // [näkyvyys] [palautettavaDatatyyppi] [metodinNimi] (parametri, pilkulla eroteltuna)
        private void printText(string message, int number)
        {
            // Private näkyvyys tarkoittaa, että sitä ei voida käyttää luokan ulkopuolelta
            // void-datatyyppi ei palauta mitään
            // parametrit-dataa, joka lähetetään funktioon
            Console.WriteLine($"Text: {message}{number}");
        }

        // Luodaan staattinen metodi
        // avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin
        // Tämä metodi voi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen
        public static int multiplyNumbers(int number1,int number2)
        {
            // public -näkyy luokan ulkopuolelle
            // static -tekee metodista staattisen (voi käyttää ilman objektia)
            // int -tämä metodi palauttaa int-arvon
            
            return number1 * number2; // return avainsanalla palautetaan arvo
        }

    }
}
