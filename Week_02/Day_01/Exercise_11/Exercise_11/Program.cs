using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10;
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 12;
            Console.WriteLine(c++);
            Console.WriteLine(c);

            int d = 12;
            Console.WriteLine(++d);
            Console.WriteLine(d);

            int e = 12;
            Console.WriteLine(e--);
            Console.WriteLine(e);

            int f = 12;
            Console.WriteLine(--f);
            Console.WriteLine(f);

            int g = 12;
            g *= 3;
            Console.WriteLine(g);

            int h = 12;
            h /= 3;
            Console.WriteLine(h);

            int i = 12;
            i %= 7;
            Console.WriteLine(i);


            Console.ReadLine();

        
        }
    }
}
