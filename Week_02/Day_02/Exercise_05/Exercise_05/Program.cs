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
            int fact = 5;
            Console.WriteLine(Factorio(fact));
            Console.ReadLine();
        }
        static public int Factorio(int fact)
        {
            int factorial = 1;
            for (int i = 1; i <= fact; i++)
            {
                factorial *= i;                
            }
            return factorial;
        }
    }
}
