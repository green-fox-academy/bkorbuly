using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_TwentyPlusOne
{
    class Card
    {
        public enum Color
        {
            red,
            black
        }
        public enum Suit
        {
            clubs,
            diamonds,
            hearts,
            spades
        }
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
    }
}
