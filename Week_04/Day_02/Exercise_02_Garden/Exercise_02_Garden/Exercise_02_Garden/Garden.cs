using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Garden
{
    class Garden
    {
        string gardenName;
        List<Flower> flowers = new List<Flower>();
        List<Tree> trees = new List<Tree>();

        public void AddFlower(Flower flower)
        {
            flowers.Add(flower);
        }
    }
}
