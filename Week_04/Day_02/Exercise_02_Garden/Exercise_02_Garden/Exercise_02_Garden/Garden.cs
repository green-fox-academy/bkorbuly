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

        public int CountPlantsInGarder()
        {
            return flowers.Count + trees.Count;
        }

        public void GardenInfo(int waterAmount)
        {
            Console.WriteLine("There are {0} flowers and {1} trees in the {2} garden.\nIn more details:\n",
                flowers.Count, trees.Count, gardenName);

            foreach(Flower flower in flowers)
            {
                flower.Info();
                flower.CheckWater();
                flower.Watering(WateringUnit(waterAmount));
            }
            foreach(Tree tree in trees)
            {
                tree.Info();
                tree.CheckWater();
                tree.Watering(WateringUnit(waterAmount));
            }
        }

        public void Info2()
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
