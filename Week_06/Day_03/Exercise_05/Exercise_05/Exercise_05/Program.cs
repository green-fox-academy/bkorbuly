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
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.WriteLine("Query:");
            QueryFrequency(n);
            Console.WriteLine("\nLambda:");
            LambdaFrequency(n);
            Console.ReadLine();
        }

        private static void QueryFrequency(int[] n)
        {
            var qFrequency = from num in n
                             group num by num into x
                             orderby x.Key
                             select x;
            foreach(var element in qFrequency)
            {
                Console.WriteLine("{0} {1}", element.Key, element.Count());
            }
        }

        private static void LambdaFrequency(int[] n)
        {
            var lFrequency = n.OrderBy(x => x).GroupBy(x => x);
            foreach (var element in lFrequency)
            {
                Console.WriteLine("{0} {1}", element.Key, element.Count());
            }
        }
    }
}
