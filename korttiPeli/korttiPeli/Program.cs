using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttiPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lisätään koodi, joka generoi pakkaan kortit
            // Lisätään pakalle metodi, jolla nostetaan yksi kortti pakasta
            
            // Kaikki pelin kortit
            Deck deck = new Deck();
            
            // Ekan pelaajan käsi
            Deck player1Deck = new Deck();
            
            // Toisen pelaajan käsi
            Deck player2Deck = new Deck();

            // Käytetään pakan generoivaa metodia 
            deck.GenerateCards();
            deck.Shuffle();

            // Pelaaja 1 nostaa kortin
            player1Deck.Cards.Add(deck.Draw());
            Console.WriteLine($"Pelaaja yksi nosti {player1Deck.Cards[0].Value} of {player1Deck.Cards[0].Suite}");
            
            // Pelaaja 2 nostaa kortin
            player2Deck.Cards.Add(deck.Draw());
            Console.WriteLine($"Pelaaja kaksi nosti {player2Deck.Cards[0].Value} of {player2Deck.Cards[0].Suite}");

            // Tilanne, jossa pelaajan 1 kortin arvo on suurempi
            if (player1Deck.Cards[0].Value > player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja yksi voitti!");
            }
            // Tilanne, jossa pelaajan 2 kortin arvo on suurempi
            else if (player1Deck.Cards[0].Value < player2Deck.Cards[0].Value)
            {
                Console.WriteLine("Pelaaja kaksi voitti!");
            }
            // Tilanne, jossa arvot ovat molemmilla pelaajilla samat
            else
            {
                if (player1Deck.Cards[0].Suite < player2Deck.Cards[0].Suite) 
                {
                    Console.WriteLine("Pelaaja yksi voitti!");
                }
                else
                {
                    Console.WriteLine("Pelaaja kaksi voitti!");
                }
            }

            Console.ReadKey();
        }
    }
}
