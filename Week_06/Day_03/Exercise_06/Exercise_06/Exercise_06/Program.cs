using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string text= "Blue Window Window Blue key flush dog umbrella";
            Console.WriteLine("Query:");
            QueryCharCount(text);
            Console.WriteLine("\nLambda:");
            LambdaCharCount(text);
            Console.ReadLine();
        }

        private static void QueryCharCount(string text)
        {
            var charCount = from letter in text
                            group letter by letter into x
                            orderby x.Key
                            select x;
            foreach (var c in charCount)
            {
                Console.Write(c.Key + " ");
            }
            Console.WriteLine();
            foreach (var c in charCount)
            {
                Console.Write(c.Count() + " ");
            }
        }

        private static void LambdaCharCount(string text)
        {
            var charCount = text.OrderBy(x => x).GroupBy(x => x);            
            foreach (var c in charCount)
            {
                Console.Write(c.Key + " ");
            }
            Console.WriteLine();
            foreach (var c in charCount)
            {
                Console.Write(c.Count() + " ");
            }
        }
    }
}
