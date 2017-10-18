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
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            Console.WriteLine("Query:");
            QueryGreaterThanTwenty(n);
            Console.WriteLine("\nLambda:");
            LambdaGreaterThanTwenty(n);
            Console.ReadLine();
        }

       

        private static void QueryGreaterThanTwenty(int[] n)
        {
            var sqaureGreaterThanTwenty = 
                from number in n
                where number * number > 20
                select number;
            foreach(int num in sqaureGreaterThanTwenty)
            {
                Console.Write(num + " ");
            }
        }
        private static void LambdaGreaterThanTwenty(int[] n)
        {
            var sqaureGreaterThanTwenty = n.Where(x => (x * x) > 20);
            foreach(int num in sqaureGreaterThanTwenty)
            {
                Console.Write(num + " ");
            }
        }
    }
}
