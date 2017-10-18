using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = new char[] { 's', 'e', 'f', 'r' };
            Console.WriteLine("Query:");
            //QueryToString(charArray);
            Console.WriteLine("Lambda:");
            LambdaToString(charArray);
            Console.ReadLine();
        }

        //private static void QueryToString(char[] charArray)
        //{
        //    var charToString = from character in charArray
        //                        in;

        //    foreach(var ch in charToString)
        //    {
        //        Console.WriteLine(ch);
        //    }
        //}

        private static void LambdaToString(char[] charArray)
        {
            var charToString = charArray.Select(x => x.ToString()).ToString();
            Console.WriteLine(charToString);
            //foreach (var ch in charToString)
            //{
            //    Console.WriteLine(ch);
            //}
        }
    }
}
