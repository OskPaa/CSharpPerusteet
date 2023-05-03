using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttiPeli
{
    class Deck
    {
        // Properties

        // Lista kortti objekteista
        public List<Card> Cards = new List<Card>();

        // Constructors
        
        //Methods

        // Generoidaan Deck luokan listaan yksi kappale jokaista korttia
        
        public void GenerateCards() 
        {
            const int numberOfValues = 13;
            // Käydään läpi korttien arvot 1-13
            for (int i =1;i<=numberOfValues;i++) 
            { 
                // Käydään läpi maat
                foreach(Card.Suites suite in Enum.GetValues(typeof(Card.Suites)))
                {
                    // Lisätään uusi kortti objekti tämän objektin kortit listaan
                    Cards.Add(new Card(i, suite));
                }
            }
        }

        public Card Draw()
        {
            Card tempCard = Cards[0];
            Cards.RemoveAt(0);
            return tempCard;
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card temp = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = temp;
            }
        }

    }
}
