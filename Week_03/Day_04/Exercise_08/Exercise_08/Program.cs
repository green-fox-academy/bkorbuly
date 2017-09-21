using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            word = Console.ReadLine();
            Console.WriteLine(RemoveXFromString(word));
            Console.ReadLine();
        }

        private static string RemoveXFromString(string word)
        {
            if ( word.Contains("x"))
            {
                return RemoveXFromString(word.Remove(word.IndexOf("x"), 1));                
            }
            return word;
        }
    }
}
