using System;
using System.Linq;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            Console.WriteLine("Query:");
            QuerySqaure(n);
            Console.WriteLine("\nLambda:");
            LambdaSqaure(n);
            Console.ReadLine();
        }

        private static void QuerySqaure(int[] n)
        {   
            var positiveSquare = (from number in n where number > 0 select number*number);
            foreach(int number in positiveSquare)
            {
                Writer(number);
            }
        }
        private static void LambdaSqaure(int[] n)
        {
            var positveSquare = n.Where(x => x > 0).Select(x => x*x);
            foreach(int number in positveSquare)
            {
                Writer(number);
            }
        }
        public static void Writer(int number)
        {
            Console.Write(number + " ");
        }
    }
}
