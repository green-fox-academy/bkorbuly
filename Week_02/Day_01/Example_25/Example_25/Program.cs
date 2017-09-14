using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("{0} * {1} = " + (i*num),i ,num);
            }
            Console.ReadLine();
        }
    }
}
