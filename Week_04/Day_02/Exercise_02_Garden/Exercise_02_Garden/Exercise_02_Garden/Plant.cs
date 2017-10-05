using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Plant
    {
        public double waterLevel;
        public bool needWaterOrNot;
        public static int counter = 0;
        protected string name;

        public Plant(double waterLevel, string name)
        {
            this.waterLevel = waterLevel;
            this.name = name;
        }

        public void Info()
        {
            Console.WriteLine("The {0}'s waterlevel is: {1}. It needs water: {2}.", name, waterLevel, needWaterOrNot);
        }
    }
    
    
}
