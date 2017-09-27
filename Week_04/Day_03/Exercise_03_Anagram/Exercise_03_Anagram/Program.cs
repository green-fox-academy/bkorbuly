using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Anagram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var ana = new Anagram();
            string text1, text2;
            text1 = Console.ReadLine();
            text2 = Console.ReadLine();
            Console.WriteLine(ana.AnagramCheck(text1, text2));
            Console.ReadLine();

        }
    }
}
