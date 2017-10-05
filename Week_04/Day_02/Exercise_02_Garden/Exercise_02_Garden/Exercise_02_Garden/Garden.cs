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
        List<Plant> plants = new List<Plant>();
        

        public Garden(string gardenName)
        {
            this.gardenName = gardenName;
        }

        public void AddFlower(Flower flower)
        {
            plants.Add(flower);
        }

        public void AddTree(Tree tree)
        {
            plants.Add(tree);
        }

        public void GardenInfo(int wateramount)
        {
            foreach(Plant plant in plants)
            {
                plant.Info();
                plant.CheckWater();

            }
        }


        public double WateringUnit(int waterAmount)
        {
            return Convert.ToDouble((waterAmount / Plant.counter));
        }

    }
}
