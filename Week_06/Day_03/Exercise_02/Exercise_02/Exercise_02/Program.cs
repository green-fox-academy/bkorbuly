using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.WriteLine("Query:");
            Console.WriteLine(program.QueryAverage(n));
            Console.WriteLine("Lamda:");
            Console.WriteLine(program.LamdaAverage(n));
            Console.ReadLine();
        }
        public double QueryAverage(int[] n)
        {
            return (from numbers in n where numbers % 2 != 0 select numbers ).Average();
        }
        public double LamdaAverage(int[] n)
        {
            return n.Where(x => (x % 2 != 0)).Average();
        }
    }
}
