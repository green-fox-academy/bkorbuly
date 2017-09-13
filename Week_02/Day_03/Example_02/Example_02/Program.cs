using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            string strtofind = "https";

            url = url.Replace("bots", "odds");

            Console.WriteLine(url.IndexOf(strtofind));

            url = url.Insert(url.IndexOf(strtofind) + 5, ":");

            Console.WriteLine(url);

            Console.ReadLine();
        }
    }
}
