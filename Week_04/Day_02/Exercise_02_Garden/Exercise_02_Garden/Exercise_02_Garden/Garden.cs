using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void GardenInfo(int waterAmount)
        {
            foreach (Plant plant in plants)
            {
                if (plant.needWaterOrNot)
                {
                    Watering(WateringUnit(waterAmount), plant);
                    MethodInfo themethod = plant.GetType().GetMethod("ReCheckWaterLevel");
                    themethod.Invoke(plant, null);
                    Plant.counter = 0;
                    ++Plant.counter;
                }
                
            }
            Printout();
        }
        public double WateringUnit(double waterAmount)
        {
            return (waterAmount / Plant.counter);
        }

        public void Watering(double waterAmount, object plant)
        {
            double waterAbsorbption = Convert.ToDouble((plant.GetType().GetField("waterAbsorbption").GetValue(plant)));
            double waterLevel = Convert.ToDouble(plant.GetType().GetField("waterLevel").GetValue(plant));
            plant.GetType().GetField("waterLevel").SetValue(plant, (waterLevel + waterAmount * waterAbsorbption));
        }

        public void Printout()
        {
            foreach(Plant plant in plants)
            {
                plant.Info();
            }
        }
    }
}
