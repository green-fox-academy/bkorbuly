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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace Exercise_10
{
    

    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var middlepoint = new Point(150, 150);
            int size = 150;
            for(int i = 0; i < 30; i++)
            {
                size = size - 5;
                    //rnd.Next(0 , 20);
                DrawSquare(foxDraw, middlepoint, size);
            }
            
        }

        private void DrawSquare(FoxDraw foxDraw, Point middlepoint, int size)
        {
            var squarepoints = new List<Point>()
            {
                new Point(middlepoint.X - size , middlepoint.Y - size ),
                new Point(middlepoint.X + size , middlepoint.Y - size ),
                new Point(middlepoint.X + size , middlepoint.Y + size ),
                new Point(middlepoint.X - size , middlepoint.Y + size ),
            };
            foxDraw.FillColor(Color.FromArgb(255, Convert.ToByte(rnd.Next(0, 256)), Convert.ToByte(rnd.Next(0, 256)), Convert.ToByte(rnd.Next(0, 256))));
            foxDraw.DrawPolygon(squarepoints);
        }
    }
}
