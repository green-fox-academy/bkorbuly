﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = 24;
            int outt = 0;
            if (w % 2 == 0)
            {
                outt++;
            }
            // if w is even increment out by one

            Console.WriteLine(outt);

            int b = 13;
            string out2 = "";
            if (10 <= b && b <= 20)
            {
                Console.WriteLine("Sweet!");
            }
            else if(b < 10)
            {
                Console.WriteLine("More");
            }
            else
            {
                Console.WriteLine("Less");
            }
            
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            if (credits >= 50 && !isBonus)
            {
                c -= 2;
            }
            else if (credits < 50 && !isBonus)
            {
                c -= 1;
            }
            else if (isBonus)
            {
                c = c;
            }
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            Console.WriteLine(c);

            int d = 8;
            int time = 210;
            string out3 = "";
            if (d % 4 == 0 && time < 200)
            {
                out3 = "check";
            }
            else if (time >= 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}
