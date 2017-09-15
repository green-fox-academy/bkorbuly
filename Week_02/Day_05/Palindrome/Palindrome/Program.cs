using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeFunction());
            Console.ReadLine();

        }

        private static string PalindromeFunction()
        {
            string word;
            char[] array; 
            word = Console.ReadLine();
            array = word.ToCharArray();
            for (int i = array.Length - 1 ; i >= 0; i--)
            {
                word = word + array[i];
            }
            return word;
        }
    }
}
