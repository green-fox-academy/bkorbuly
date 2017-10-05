using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowerList = new List<Plant>();
                flowerList.Add(new Flower(15, "blue"));
                flowerList.Add(new Flower(5, "yellow"));
                flowerList.Add(new Flower(24, "orange"));
                flowerList.Add(new Flower(34, "black"));
            
            foreach(Plant flower in flowerList)
            {
                flower.Info();
            }
            Console.ReadLine();
        }
    }
}
