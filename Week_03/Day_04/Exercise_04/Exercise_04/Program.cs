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
            int basen, powerto;
            basen = powerto = 0;
            basen = Convert.ToInt32(Console.ReadLine());
            powerto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowerToN(basen, powerto));
            Console.ReadLine();
        }

        public static int PowerToN(int basen, int powerto)
        {
            if (powerto > 1)
            {
                return basen * PowerToN(basen, --powerto);
            }

            return basen;

        }
    }
}
