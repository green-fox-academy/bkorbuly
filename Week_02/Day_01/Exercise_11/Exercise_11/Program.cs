﻿using System;
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

            int c = 44;
            Console.WriteLine(c * 2);

            int d = 125;
            Console.WriteLine(d / 5);

            int e = 8;
            Console.WriteLine(e * e * e);

            int f1 = 123;
            int f2 = 345;
            Console.WriteLine(f1 > f2);

            int g1 = 350;
            int g2 = 200;
            Console.WriteLine((g2 * 2) > g1);
            
            long h = 1357988018575474;
            Console.WriteLine(h / 11 == 0);
            
            int i1 = 10;
            int i2 = 3;
            Console.WriteLine((i1 > i2 * i2) && (i1 < (i2 * i2 * i2)));

            int j = 1521;
            Console.WriteLine((j / 3 == 0) || (j / 5 == 0));
           
            string k = "Apple";
            Console.WriteLine("{0}{0}{0}{0}", k);
            Console.ReadLine();

        
        }
    }
}
