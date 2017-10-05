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
           
            var garden = new Garden("Garden1");
            garden.AddFlower(new Flower(5, "yellow"));
            garden.AddFlower(new Flower(25, "black"));
            garden.AddFlower(new Flower(15, "orange"));

            //garden.GardenInfo(10);
            garden.Info2();
            Console.ReadLine();
        }
    }
}
