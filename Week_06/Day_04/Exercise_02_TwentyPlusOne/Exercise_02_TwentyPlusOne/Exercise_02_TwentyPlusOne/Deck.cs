using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_TwentyPlusOne
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        public List<Card> CreateDeck()
        {
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            var ranks = Enum.GetValues(typeof(Rank)).Cast<Rank>();
            var fillingDeck = suits.SelectMany(x => ranks, (a, b) => new Card(a, b)).ToList();
            foreach (var card in fillingDeck)
            {
                Console.WriteLine("{0} {1}", card.Suit, card.Rank);
            }

            return deck = fillingDeck;
        }

        public Card PullFirst()
        {
            var firsCard = deck.First();
            Console.WriteLine("{0} {1}", firsCard.Suit, firsCard.Rank);
            return firsCard;
        }

        public Card PullLast()
        {
            var lastCard = deck.Last();
            Console.WriteLine("{0} {1}", lastCard.Suit, lastCard.Rank);
            return lastCard;
        }
    }
}
