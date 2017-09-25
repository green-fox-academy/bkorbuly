using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Reflection;
using System.Drawing;

namespace BulitinColorList
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Color> allColors = new List<Color>();
            Console.WriteLine(typeof(Color));
            GetAllColors(allColors);
            foreach (Color color in allColors)
            {
                Console.WriteLine(color);
            }

            //Console.WriteLine(allColors[rnd.Next(0 , allColors.Count - 1)]);
            Console.ReadLine();
        }
        public static List<Color> GetAllColors(List<Color> allColors)
        {
            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    allColors.Add((Color)property.GetValue(null));
                }
            }

            return allColors;
        }
    }
}
