using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            Console.WriteLine((23*60*60 - currentHours * 60 * 60) + (59 * 60 - currentMinutes * 60) + (60 - currentSeconds));
            Console.WriteLine(23 * 60 * 60 - currentHours * 60 * 60);
            Console.WriteLine(59 * 60 - currentMinutes * 60);
            Console.WriteLine(60 - currentSeconds);

            Console.ReadLine();
        }
    }
}
