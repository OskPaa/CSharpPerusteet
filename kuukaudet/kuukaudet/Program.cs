using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuukaudet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna kuukausi(1-12):"); // kysytään käyttäjältä kuukausi numerona
            int month = int.Parse(Console.ReadLine()); // käyttäjä syöttää kuukauden numerona

            // if else -rakenne

            if ((month >= 1 && month <= 3) || (month >= 11 && month <= 12)) // Määritellään ehdot talven viestille
            {
                Console.WriteLine("Kuukautesi kuuluu talveen."); // Tulostetaan talven viesti
            }
            else if (month == 4 || month == 5) // Määritellään ehdot kevään viestille
            {
                Console.WriteLine("Kuukautesi kuuluu kevääseen."); // Tulostetaan kevään viesti
            }
            else if (month >= 6 && month <= 8) // Määritellään ehdot kesän viestille
            {
                Console.WriteLine("Kuukautesi kuuluu kesään."); // Tulostetaan kesän viesti
            }
            else if (month == 9 || month == 10) // Määritellään ehdot syksyn viestille
            {
                Console.WriteLine("Kuukautesi kuuluu syksyyn."); // Tulostetaan syksyn viesti
            }
            else
            {
                Console.WriteLine($"Luvulle {month} ei ole vastaavaa kuukautta."); // Sanotaan, ettei käyttäjän antamalla numerolla ole vastaavaa kuukautta
            }

            // switch case -rakenne

            Console.Write("Anna kuukauden nimi:");
            string monthName = Console.ReadLine();

            switch (monthName) // Laitetaan switch casen vertailtavaksi arvoksi month-muuttuja 
            {
                case "tammikuu": // Määritellään talven tapauksia
                case "helmikuu": // Määritellään talven tapauksia
                case "maaliskuu": // Määritellään talven tapauksia
                case "marraskuu": // Määritellään talven tapauksia
                case "joulukuu": // Määritellään talven tapauksia
                    Console.WriteLine("Kuukautesi kuuluu talveen."); // Tulostetaan talven viesti
                    break; // Päätetään talven tapaukset

                case "huhtikuu": // Määritellään kevään tapauksia
                case "toukokuu": // Määritellään kevään tapauksia
                    Console.WriteLine("Kuukautesi kuuluu kevääseen."); // Tulostetaan kevään viesti
                    break; // Päätetään kevään tapaukset

                case "kesäkuu": // Määritellään kesän tapauksia
                case "heinäkuu": // Määritellään kesän tapauksia
                case "elokuu": // Määritellään kesän tapauksia
                    Console.WriteLine("Kuukautesi kuuluu kesään."); // Tulostetaan kesän viesti
                    break; // Päätetään kesän tapaukset

                case "syyskuu": // Määritellään syksyn tapauksia
                case "lokakuu": // Määritellään syksyn tapauksia
                    Console.WriteLine("Kuukautesi kuuluu syksyyn."); // Tulostetaan syksyn viesti
                    break; // Päätetään syksyn tapaukset

                default: // Oletustapaus
                    Console.WriteLine($"Kuukauttaa nimeltään {monthName} ei ole olemassa."); // Sanotaan, ettei käyttäjän antamalla numerolla ole vastaavaa kuukautta
                    break; // Päätetään oletustapaus
            }

            // ternary-rakenne

            string message = month == 1 || month == 2 || month == 3 || month == 11 || month == 12 ? "Kuukautesi kuuluu talveen." : // Talviviestin ehdot ja arvo
                month == 4 || month == 5 ? "Kuukautesi kuuluu kevääseen." : // Kevätviestin ehdot ja arvo
                month == 6 || month == 7 || month == 8 ? "Kuukautesi kuuluu kesään." : // Kesäviestin ehdot ja arvo
                month == 9 || month == 10 ? "Kuukautesi kuuluu syksyyn." : // Syksyviestin ehdot ja arvo
                $"Luvulle {month} ei ole vastaavaa kuukautta."; // Oletustapauksen arvo
            Console.WriteLine(message); // tulostetaan ternary-rakenteen  valitsema viesti

            // suljetaan ohjelma
            Console.WriteLine();
            Console.WriteLine("Press any key to close program");
            Console.ReadKey();
        }
    }
}
