using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            AppendA(am);
            Console.ReadLine();
        }
        static void AppendA(string a)
        {
            Console.WriteLine(a + "a");
        }
    }
}
