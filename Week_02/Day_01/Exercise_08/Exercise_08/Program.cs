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
            int a = -123;
            int b = 526;
            int c = 0;

            Console.WriteLine("Original order: " + "\n a:" + a + "\n b:" + b );

            c = a;
            a = b;
            b = c;
            //a = a ^ b;
            //b = b ^ a;
            //a = a ^ b;

            Console.WriteLine("Swapped order:\n a:" + a + "\n b:" + b );

            Console.ReadLine();
        }
    }
}
