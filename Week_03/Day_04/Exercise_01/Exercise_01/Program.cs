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
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Counter(num);
            Console.ReadLine();
        }
        public static int Counter(int num)
        {
            if(num == 0 )
            {
                Console.WriteLine("0");
                return 0;
            }
            else
            {
                Console.WriteLine(num);
                return Counter(num - 1);
            }
        }
    }
}
