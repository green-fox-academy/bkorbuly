using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;
using System.Reflection;
using System.Windows.Media;

namespace Exercise_10
{
    

    public partial class MainWindow : Window
    {
        static Random rnd = new Random();

        public MainWindow()
        {
            List<Color> allColors = new List<Color>();
            allColors = GetAllColors();
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var middlepoint = new Point(150, 150);
            int size = 150;
            for (int i = 0; i < 30; i++)
            {
                size = size - 5;
                //rnd.Next(0 , 20);
                foxDraw.FillColor(allColors[rnd.Next(0, allColors.Count - 1)]);
                DrawSquare(foxDraw, middlepoint, size);
            }
            
        }

        public void DrawSquare(FoxDraw foxDraw, Point middlepoint, int size)
        {
            var squarepoints = new List<Point>()
            {
                new Point(middlepoint.X - size , middlepoint.Y - size ),
                new Point(middlepoint.X + size , middlepoint.Y - size ),
                new Point(middlepoint.X + size , middlepoint.Y + size ),
                new Point(middlepoint.X - size , middlepoint.Y + size ),
            };
            //foxDraw.FillColor(Color.FromArgb(255, Convert.ToByte(rnd.Next(0, 256)), Convert.ToByte(rnd.Next(0, 256)), Convert.ToByte(rnd.Next(0, 256))));
            foxDraw.DrawPolygon(squarepoints); 
        }

        public List<Color> GetAllColors()
        {
            List<Color> allColors = new List<Color>();
            foreach (PropertyInfo property in typeof(System.Drawing.Color).GetProperties())
            {
                if (property.PropertyType == typeof(System.Drawing.Color))
                {
                    var drawingcolor = (System.Drawing.Color)property.GetValue(null);
                    allColors.Add
                    (
                        System.Windows.Media.Color.FromArgb(drawingcolor.A, drawingcolor.R, drawingcolor.G, drawingcolor.B)
                    );
                }
            }
            return allColors;
        }
    }
}
