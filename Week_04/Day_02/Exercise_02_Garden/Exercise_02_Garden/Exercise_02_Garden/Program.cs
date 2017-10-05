using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower1 = new Flower(10, "yellow");
            flower1.Info();
            Console.ReadLine();
        }
    }
}
