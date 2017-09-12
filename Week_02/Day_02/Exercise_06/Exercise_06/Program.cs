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
           Printer("first", "second", "third", "fourth");
            Console.ReadLine();


        }
        static public void Printer(params string[] words)
        {
            foreach(string word in words)
            {
                Console.Write(word + " ");
            }
            
        }
    }
}
