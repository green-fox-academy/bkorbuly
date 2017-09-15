using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int line;
            line = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= line; i++)
            {

                for (int j = line; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 -1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
