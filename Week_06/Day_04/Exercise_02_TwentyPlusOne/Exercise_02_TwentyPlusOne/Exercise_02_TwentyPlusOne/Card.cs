using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_TwentyPlusOne
{
    public enum Rank
    {
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        nine = 9,
        ten = 10,
        J,
        Q,
        K,
        A
    }
    public enum Suit
    {
        clubs,
        diamonds,
        hearts,
        spades
    }

    class Card
    {
        public enum Color
        {
            red,
            black
        }        

        protected Rank rank;
        protected Suit suit;

        public Rank Rank
        {
            get { return rank; }
        }

        public Suit Suit
        {
            get { return suit; }
        }


        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}
