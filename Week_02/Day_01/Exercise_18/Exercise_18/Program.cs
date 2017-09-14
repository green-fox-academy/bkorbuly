using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string read;
            int num;
            read = Console.ReadLine();
            num = Convert.ToInt32(read);
            if ( (num % 2) == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
        }
    }
}
