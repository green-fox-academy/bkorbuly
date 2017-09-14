using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
                {
                    Console.WriteLine("Not enough");
                }
                else if (num == 1)
                {
                    Console.WriteLine("One");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Two");
                }
                else
                {
                    Console.WriteLine("A lot");
                }
            Console.ReadLine();
        }
    }
}
