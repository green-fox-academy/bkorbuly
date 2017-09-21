using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Counter(num));
            Console.ReadLine();
        }

        public static int Counter(int num)
        {
            if (num > 0)
            {
              return num + Counter(--num);
            }
            return num;
        }
    }
}
