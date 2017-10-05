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
            garden.AddTree(new Tree(15, "green"));
            garden.AddTree(new Tree(1, "red"));

            garden.GardenInfo(20);
            Console.WriteLine();
            garden.GardenInfo(5);
            Console.ReadLine();
        }
    }
}
