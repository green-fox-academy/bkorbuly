using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1, word2;
            word1 = Input_1(Console.ReadLine());
            word2 = Input_1(Console.ReadLine());
            while(word1.Length != word2.Length)
            {
                Console.WriteLine("Word #2 does not have same length as Word #1! Please add a new word:");
                word2 = Input_1(Console.ReadLine());
            }
            AnagramOrNot(word1, word2);
            Console.ReadLine();
        }

        private static void AnagramOrNot(string word1, string word2)
        {
            int correct = 0;
            for (int i=0; i < word1.Length; i++)
            {
                if(word1[i] == word2[i])
                {
                    correct++;
                }
            }
            if (correct == word1.Length)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        private static string Input_1(string word)
        {
            char[] array = word.ToCharArray();
            Array.Sort(array);
            return new string(array);
        }

    }
}
