using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string strtarget1 = "It you";
                       
            StringBuilder quote = new StringBuilder("Hofstadter's Law: It you expect," +
                "\neven when you take into account Hofstadter's Law.");

            
            if (quote.ToString().IndexOf(strtarget1) >-1)

            quote.Insert(quote.ToString().IndexOf(strtarget1) +3, "always takes longer than ");

            Console.WriteLine(quote);

           Console.Read();
        }
    }
}
