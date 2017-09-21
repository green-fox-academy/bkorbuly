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
            int bunnies = 0;
            bunnies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountEars(bunnies));
            Console.ReadLine();
        }

        private static int CountEars(int bunnies)
        {
            if (bunnies > 0)
            {
                if ( bunnies % 2 == 1)
                {
                    Console.WriteLine(bunnies + " 3 ears");
                    return 3 + CountEars(--bunnies);
                }
                Console.WriteLine(bunnies + " 2 ears");
                return 2 + CountEars(--bunnies);
            }
            return bunnies;
        }
    }
}
