using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Tree : Plant
    {
            new int waterMin = 5;
            new double waterAbsorbption = 0.40;
        public Tree(double waterLevel, string name) :base(waterLevel, name)
        {
            this.name = name.Insert(name.Length, " Tree");            
        }
    }
}
