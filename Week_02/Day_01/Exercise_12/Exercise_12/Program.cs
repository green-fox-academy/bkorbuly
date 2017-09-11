using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height = 0;

            length = 15;
            width = 25;
            height = 30;
            Console.WriteLine("Surface Area: " + 2 * (length * width + width * height + height * length));
            Console.WriteLine("Volume: " + (length * width * height) );

            Console.ReadLine();
        }
    }
}
