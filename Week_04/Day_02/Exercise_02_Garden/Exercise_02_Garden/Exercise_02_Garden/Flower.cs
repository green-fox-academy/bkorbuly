using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Flower : Plant
    {
        int waterMin = 10;
        public double waterAbsorbption = 0.75;

        public Flower(double waterLevel, string name) : base(waterLevel, name)
        {
            this.name = name.Insert(name.Length, " Flower");
            if (waterLevel < waterMin)
            {
                needWaterOrNot = true;
                ++Plant.counter;
            }
        }

        public void ReCheckWaterLevel()
        {
            needWaterOrNot = (waterLevel < waterMin) ? true : false;
        }
    }
}
