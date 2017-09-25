using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrom("greefox"));
            Console.ReadLine();
        }

        static private void Search(string word)
        { 
            


        }
        private static string Palindrom(string original)
        {
            char[] array = original.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
    }
}
