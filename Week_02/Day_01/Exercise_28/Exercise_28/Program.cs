using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int line;
            line = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < line; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
    }
}
