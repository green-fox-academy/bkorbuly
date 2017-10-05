using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Flower : Plant
    {
        public Flower(double waterLevel, string name) : base(waterLevel, name)
        {
            int waterMin = 10;
            double waterAbsorbption = 0.75;
            this.name = name.Insert(name.Length, " Flower");
        }

      
    }
}
