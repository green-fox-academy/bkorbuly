using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Console.WriteLine("Query:");
            QueryCities(cities);
            Console.WriteLine("Lambda:");
            LambdaCities(cities);
            Console.ReadLine();
        }

        private static void QueryCities(string[] cities)
        {
            var cityAI = from city in cities
                         where city.IndexOf('A') == 0 && city.Last() == 'I'
                         select city;
            foreach(var city in cityAI)
            {
                Console.WriteLine(city);
            }
        }

        private static void LambdaCities(string[] cities)
        {
            var cityAI = cities.Where(x => x.IndexOf('A') == 0 && x.Last() == 'I');
            foreach (var city in cityAI)
            {
                Console.WriteLine(city);
            }
        }
    }
}
