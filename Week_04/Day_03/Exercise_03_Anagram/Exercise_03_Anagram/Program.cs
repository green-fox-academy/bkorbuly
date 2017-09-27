using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1, text2;
            text1 = Console.ReadLine();
            text2 = Console.ReadLine();
            Console.WriteLine(Anagram(text1, text2));
            Console.ReadLine();

        }
        static bool Anagram(string text1, string text2)
        {
            bool anagram = false;
            char[] array1, array2;
            if (text1.Length == text2.Length)
            {
                array1 = text1.ToCharArray();
                array2 = text2.ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);
                anagram = array1.SequenceEqual(array2);
            }
            return anagram;
        }
    }
}
