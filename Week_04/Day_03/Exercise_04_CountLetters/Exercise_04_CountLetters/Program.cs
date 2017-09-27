using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04_CountLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inst = new CountLetters();
            Dictionary<char, int> map = new Dictionary<char, int>();
            map = inst.CountLetter("ablak ami nagyon ablak");
            foreach (var element in map)
            {
                Console.WriteLine("{0}, {1}",  element.Key, element.Value);
            }
            Console.ReadLine();
        }
    }
}
