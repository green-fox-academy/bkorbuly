using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Tree : Plant
    {
        int waterMin = 5;
        public double waterAbsorbption = 0.5;
        public Tree(double waterLevel, string name) :base(waterLevel, name)
        {
            this.name = name.Insert(name.Length, " Tree");
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
