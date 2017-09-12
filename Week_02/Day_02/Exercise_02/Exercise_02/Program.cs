using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Console.WriteLine(Greet(al));
            Console.ReadLine();
        }
        static public string Greet(string al)
        {
            return ("Greetings dear, " + al);
        }
    }
}
