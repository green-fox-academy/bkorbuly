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

namespace Exercise_02
{
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            var pointList = new List<Point>()
            {
                new Point(10, 10),
                new Point(290, 10),
                new Point(290, 290),
                new Point(10, 290),
            };
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(pointList[0],pointList[1]);
            foxDraw.StrokeColor(Colors.Yellow);
            foxDraw.DrawLine(pointList[1], pointList[2]);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(pointList[2], pointList[3]);
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.DrawLine(pointList[3], pointList[0]);
            //foxDraw.FillColor(Colors.Black);
            //foxDraw.DrawPolygon(pointList);
        }
    }
}
