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

namespace Exercise_11
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Point start = new Point(10, 10);
            int size = 20;
            for (int i = 0; i < 14; i++)
            {
                DrawSquares(foxDraw, size, start);
                start.X = start.X + size;
                start.Y = start.Y + size;
            } 
            

        }

        private void DrawSquares(FoxDraw foxDraw, int size, Point start)
        {
            var pointlist = new List<Point>()
            {
                new Point(start.X , start.Y),
                new Point(start.X + size , start.Y),
                new Point(start.X + size , start.Y + size),
                new Point(start.X , start.Y + size),
            };
            foxDraw.FillColor(Colors.Purple);
            foxDraw.DrawPolygon(pointlist);
        }
    }
}
