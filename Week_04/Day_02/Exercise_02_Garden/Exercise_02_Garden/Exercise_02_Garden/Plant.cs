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
        public bool needWaterOrNot;
        public static int counter;
        protected int waterMin;
        protected double waterAbsorbption;
        protected string name;

        public Plant(double waterLevel, string name)
        {
            this.waterLevel = waterLevel;
            this.name = name;
            if (waterLevel < waterMin)
            {
                counter++;
            }
        }

        public void Watering(double waterAmount)
        {
            waterLevel += waterAmount * waterAbsorbption;
            Console.WriteLine("Watering with {0}", waterAmount * waterAbsorbption);
            Info();
            Console.WriteLine();
        }

        public bool CheckWater()
        {
            if(waterLevel > waterMin)
            {
                Console.WriteLine("The {0} does not need water.", name);
                return needWaterOrNot = false;
            }
            else
            {
                Console.WriteLine("The {0} needs water.", name);
                return needWaterOrNot = true;
            }
        }

        public void Info()
        {
            Console.WriteLine("The {0}'s waterlevel is: {1}.", name, waterLevel);
        }
    }
    
    
}
