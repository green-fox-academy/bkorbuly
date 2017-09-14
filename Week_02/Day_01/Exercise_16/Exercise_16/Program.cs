using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {

            int chicken, pig;

            Console.Write("Please add how many chicken(s) is/are on the farm: ");
            chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(chicken);

            Console.Write("Please add how many pig(s) is/are on the farm: ");
            pig = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("There are " + (chicken * 2 + pig * 4) + " total legs are on the farm");

            Console.ReadLine();
        }
    }
}
