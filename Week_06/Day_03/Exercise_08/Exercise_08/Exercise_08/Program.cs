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
            string text = "Blue Window";
            Console.WriteLine("Quary:");
            QuaryUppercase(text);
            Console.WriteLine("\nLambda:");
            LambdaUppercase(text);
            Console.ReadLine();
        }

        private static void QuaryUppercase(string text)
        {
            var upperCases = from letter in text
                             where char.IsUpper(letter) 
                             select letter;
            foreach(var letter in upperCases)
            {
                Console.Write(letter);
            }
        }

        private static void LambdaUppercase(string text)
        {
            var upperCases = text.Where(x => char.IsUpper(x));
            foreach (var letter in upperCases)
            {
                Console.Write(letter);
            }
        }
    }
}
