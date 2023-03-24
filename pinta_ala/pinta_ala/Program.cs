using System;

namespace pinta_ala
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna korkeus metreinä:");
            int korkeus = Int32.Parse(Console.ReadLine());
            Console.Write("Anna leveys metreinä:");
            int leveys = Int32.Parse(Console.ReadLine());
            int pintaAla = korkeus * leveys;
            Console.WriteLine($"Antamillasi mitoilla pinta-ala on {pintaAla} neliömetriä.");
        }
    }
}
