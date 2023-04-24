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
            int fivetimesthree = MultiplyNumbers(5,3); // metodi palauttaa arvon, se pitää ottaa talteen
            // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa
            // Nyt multiplyNumbers() palautettava arvo toimii metodille "WriteLine"
            Console.WriteLine(MultiplyNumbers(5, 3));

            #endregion
            // 2.Luokka / Class
            #region
            // Olio-ohjelmoinnin pohjimmainen idea on jakaa sovellus pieniin kokonaisuuksiin (luokkiin/olioihin)
            // Idea on jakaa laaja ongelma pieniin osiin
            // Sovelluksissa on pääsääntöisesti kahta asiaa: 1.Data (Property), 2.Toiminnallisuus (Method)
            // Luokkien idea on  yhdistää oleellinen data ja toiminnallisuus yhteen pakettiin

            // Luokan luomisen sijainti, samalle tasolle muiden luokkien kanssa
            // Tässä tiedostossa "Program"-luokan kanssa samalle tasolle

            // Luodaan luokasta objekteja
            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";

            Console.WriteLine($"Henkilön A nimi on: {personA.Name} ja ikä on: {personA.Age}");
            
            Person personB = new Person(25,"Matti",1.8,new List<Pet>());
            
            Person personC = new Person(35,"Jesse",179.6, new List<Pet>());

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
            // Private näkyvyys tarkoittaa, että sitä ei voida käyttää luokan ulkopuolelta, kirjoitetaan pienellä
            // void-datatyyppi ei palauta mitään
            // parametrit-dataa, joka lähetetään funktioon
            Console.WriteLine($"Text: {message}{number}");
        }

        // Luodaan staattinen metodi
        // avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin
        // Tämä metodi voi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen
        public static int MultiplyNumbers(int number1,int number2)
        {
            // public -näkyy luokan ulkopuolelle, kirjoitetaan nimi isolla kirjaimella
            // static -tekee metodista staattisen (voi käyttää ilman objektia)
            // int -tämä metodi palauttaa int-arvon
            
            return number1 * number2; // return avainsanalla palautetaan arvo
        }

    }
    // class - avainsana
    // Test - oman luokan nimi, isolla kirjaimella
    class Person // Luokkien idea on mallintaa jotakin todellista asiaa tiettyyn pisteeseen saakka
    {

        // 2a. Property
        // kirjoita prop and sen jälkeen sarkain kaksi kertaa
        // Propertyn syntaksi:[Näkyvyys] [nimi] [get ja set]
        // [get ja set] get määrittää kuinka arvo luetaan aj set kuinka arvo tallennetaan
        public int Age { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Location CurrentLocation { get; set; }
        public Location newLocation { get; set; }
        public List<Pet> Pets { get; set; }

        // 2b. Constructor
        // Erityis metodi, jolla tallenetaan objektiin oletusarvoja
        // [nimi], joka täytyy olla täysin sama kuin luokan nimi

        public Person() // Constructorista voi tehdä eri versioita
        {

        }

        public Person(int age, string name, double length, List<Pet> pets)
        {
            Age = age;
            Name = name;
            Length = length;
            Pets = pets;
        }

        // 2c. Metodi / Method
        // Toiminnallisuus
        
        // Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä
        public int Walk(Location location) 
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;

            CurrentLocation = newLocation;
            return result;
        }
    }
    public class Location 
    {
        public int CoordinateX { get; set; }
    }
    public class Pet 
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
