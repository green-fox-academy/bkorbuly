using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01_ParkingLot
{
    class Car
    {
        static Random rnd = new Random();
        public static List<Car> carlist = new List<Car>();
   
        CarType type;
        CarColor color;       

        public Car(CarType type, CarColor color)
        {
            this.type = type;
            this.color = color;
        }
        public enum CarType
        {
            sedan = 0,
            coupe = 1,
            sport = 2,
            family = 3,
            hatchback = 4,
            SUV= 5
        }
        public enum CarColor
        {
            yellow = 0,
            green = 1,
            black = 2,
            blue = 3,
            red = 4,
            grey = 5,
            purple = 6,
            pink = 7
        }

        public static List<Car> CarInitialization()
        {
            
            for(int i = 0; i < 257; i++)
            {
                CarType type = (CarType)rnd.Next(0, 6);
                CarColor color = (CarColor)rnd.Next(0, 8);
                carlist.Add(new Car(type, color));
                Console.WriteLine("{0} {1}", type, color);
            }

            return carlist;
        }

        public static void CountTypes()
        {
            var countTypes = carlist.GroupBy(x => x.type);
            Console.WriteLine("\nTypes: Quantity:");
            foreach(var types in countTypes)
            {
                Console.WriteLine("{0} {1}", types.Key, types.Count());
            }
        }
    }
}
