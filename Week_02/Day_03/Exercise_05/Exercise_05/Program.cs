using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht\n " +
                ",dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            //char[] array = reversed.ToCharArray();
            //Array.Reverse(array);
            //reversed =new string(array);

            //Console.WriteLine(reversed);
            //Console.ReadLine();        
            Console.WriteLine(Rev(reversed));
            Console.ReadLine();

        }
        static public string Rev(string s)
        {
            char[] array = s.ToCharArray();
            char container;
            //Console.WriteLine(array.GetLength(0));
            for (int i = 0; i < (array.GetLength(0)/2); i++)
            {
                int endindex = array.GetLength(0) -1 -i;
                container = array[i];
                array[i] = array[endindex];
                array[endindex] = container;
                //Console.WriteLine("{0} {1}" , i , endindex);
            }
            return (new string(array));
        }


    }
}
