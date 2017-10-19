using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carTest1 = new Car(Car.CarType.coupe, Car.CarColor.black);
            var carTest2 = new Car(Car.CarType.coupe, Car.CarColor.black);
            Car.CarInitialization();
            Car.CountTypes();
            Car.CountColor();
            if (carTest1.Equals(carTest2))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Car.MostFrequentlyType();
            Console.ReadLine();
        }
    }
}
