using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] read = new string[2];
            read = Console.ReadLine().Split(' ');
            if (Convert.ToInt32(read[0]) > Convert.ToInt32(read[1]))
            {
                Console.WriteLine(read[0]);
            }
            else
            {
                Console.WriteLine(read[1]);
            }
            Console.ReadLine();
        }
    }
}
