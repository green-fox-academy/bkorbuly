using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sum = new string[5];
            int add = 0;
            double avg = 0;
            Console.Write("Please add 5 numbers seperated by space(' '): ");
            sum = Console.ReadLine().Split(' ');
            for (int i = 0; i < sum.Length; i++)
            {
                add += Convert.ToInt32(sum[i]);
            }
            avg = add / sum.Length;
            Console.WriteLine("Sum: " + add + " Average: " + avg);
    
            Console.ReadLine();
        }
    }
}
