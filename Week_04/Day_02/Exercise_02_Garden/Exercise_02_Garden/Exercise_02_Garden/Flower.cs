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
            this.name = name.Insert(name.Length, " Flower");
            waterMin = 10;
            waterAbsorbption = 0.75;
        }

      
    }
}
