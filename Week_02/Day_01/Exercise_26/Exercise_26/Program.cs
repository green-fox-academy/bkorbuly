using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("first number {0}, second number {1}, counting:\n", num1, num2 );
            if (num1 >= num2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i=num1; i < num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
                    

            Console.ReadLine();
        }
    }
}
