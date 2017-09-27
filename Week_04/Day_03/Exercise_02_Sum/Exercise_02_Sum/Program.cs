using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new SUM();
            var numlist = new List<int>()
            {
                2, 3, 4, 5, 6
            };
            Console.WriteLine(numbers.Summary(numlist));

            Console.ReadLine();
        }
    }
}
