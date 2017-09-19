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
            Divide();
            Console.ReadLine();
        }

        private static void Divide()
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
        }
    }
}
