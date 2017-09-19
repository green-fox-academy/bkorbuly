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
            DivideZerobyTen();
            DivideNumbyZero();
            Console.ReadLine();
        }

        private static void DivideNumbyZero()
        {
            int num, result;
            num = int.Parse(Console.ReadLine());
            try
            {
                result = 10 / num;
                Console.WriteLine(num);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
            }
        } 
            
            
        private static void DivideZerobyTen()
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine()) / 10;
                if (num == 0)
                {
                    throw new ArithmeticException();
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Not possible to divide 0 by any number");
            }
        }
    }
}
