using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var program = new Program();
            Console.WriteLine("Lamda:");
            program.LamdaEven(n);
            Console.WriteLine("\nQuery:");
            QueryEven(n);
            Console.ReadLine();
        }
        public static void QueryEven(int[] n)
        {
            var evenNumbers =
               from num in n
               where num % 2 == 0
               select num;
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write(evenNumber + " ");
            }
        }
        public void LamdaEven(int[] n)
        {
            var evenNumbers = n.Where(num => num % 2 == 0); 
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write(evenNumber + " ");
            }
        }
    }
}
