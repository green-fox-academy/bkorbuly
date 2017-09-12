using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = num2 = num3 = 30;
            Sum(num1, num2, num3);
            Console.ReadLine();

        }
        static public void Sum(int num1, int num2, int  num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
    }
}
