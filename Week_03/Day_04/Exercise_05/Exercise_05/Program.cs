using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunniesnumber;
            bunniesnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountEars(bunniesnumber));
            Console.ReadLine();
        }

        private static int CountEars(int bunniesnumber)
        {
            if ( bunniesnumber > 0)
            {
                return  2 + CountEars(--bunniesnumber); 
            }
            return bunniesnumber;
        }
    }
}
