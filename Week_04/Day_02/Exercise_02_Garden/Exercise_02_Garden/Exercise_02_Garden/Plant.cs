using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Plant
    {
        double waterLevel;
        protected int waterMin;
        protected double waterAbsorbption;
        protected string name;

        public Plant(double waterLevel, string name)
        {
            this.waterLevel = waterLevel;
            this.name = name;
        }

        public void Watering(int waterAmount)
        {
            waterLevel += waterAmount*waterAbsorbption;
        }

        public void CheckWater()
        {
            if(waterLevel > waterMin)
            {
                Console.WriteLine("The {0} does not need water.", name);
            }
            else
            {
                Console.WriteLine("The {0} needs water.", name);
            }
        }

        public void Info()
        {
            Console.WriteLine("The {0}'s waterlevel is: {1}", name, waterLevel);
        }
    }
    
    
}
