using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };
            planetList.Add("Saturn");
            foreach (string planet in planetList)
            {
            Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
    }
}
