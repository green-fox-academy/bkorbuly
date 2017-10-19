using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_TwentyPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.CreateDeck();
            Console.WriteLine();
            deck.PullFirst();
            Console.WriteLine();
            deck.PullLast();
            Console.ReadLine();
        }
    }
}
