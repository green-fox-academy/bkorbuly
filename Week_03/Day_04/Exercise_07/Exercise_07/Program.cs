using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            word = (Console.ReadLine());
            Console.WriteLine(ChangeLowXTOY(word.ToCharArray(), word.Length - 1));
            Console.ReadLine();
        }

        private static string ChangeLowXTOY(char[] word, int i)
        {
            if ( i >= 0)
            {
                if (word[i] == 'x')
                {
                    word[i] = 'y';
                    return ChangeLowXTOY(word, --i);
                }
                return ChangeLowXTOY(word, --i);
                
            }      
            return new string(word);
        }
    }
}
