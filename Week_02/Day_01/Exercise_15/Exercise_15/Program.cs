using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;

            Console.Write("Please add the km: ");

            km = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("It equals " + km * 0.621371192 + " miles");

            Console.ReadLine();

        }
    }
}
