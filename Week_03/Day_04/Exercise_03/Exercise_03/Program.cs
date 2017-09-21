using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitSum(num));
            Console.ReadLine();
        }

        private static int DigitSum(int num)
        {
            if (num / 10 > 0)
            {
                return (num % 10) + DigitSum(num / 10);
            }
            else
            {
                return num;
            }
        }
    }
}
