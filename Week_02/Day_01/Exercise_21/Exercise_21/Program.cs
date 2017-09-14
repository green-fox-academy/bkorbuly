using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int girls, boys;
            Console.Write("Please give the number of girls who are coming to the party: ");
            girls = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give the number of boys who are coming to the party: ");
            boys = Convert.ToInt32(Console.ReadLine());
            if ( girls == boys && girls + boys > 20)
            {
                Console.WriteLine("The party is excellent");
            }
            else if ( ( girls/boys != 1 && girls >0 ) && (girls + boys > 20) )
            {
                Console.WriteLine("Quite cool party");
            }
            else if ( girls != 0 && girls + boys <=20)
            {
                Console.WriteLine("Average party");
            }
            else if ( girls == 0) 
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
        }
    }
}
