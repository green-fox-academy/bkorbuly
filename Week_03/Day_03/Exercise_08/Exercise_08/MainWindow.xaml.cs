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

namespace Exercise_08
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            var foxDraw = new FoxDraw(canvas);
            var startpoint = new Point(30 , 30);
            var startpoint2 = new Point(rnd.Next(0 , 251) , rnd.Next(0 , 251));
            var startpoint3 = new Point(rnd.Next(0, 251), rnd.Next(0, 251));

            DrawSquare(foxDraw, startpoint);
            DrawSquare(foxDraw, startpoint2);
            DrawSquare(foxDraw, startpoint3);
        }

        private void DrawSquare(FoxDraw foxDraw, Point startpoint)
        {
            var pointlist = new List<Point>()
            {
                new Point (startpoint.X, startpoint.Y),
                new Point (startpoint.X + 50 , startpoint.Y),
                new Point (startpoint.X + 50 , startpoint.Y + 50),
                new Point (startpoint.X , startpoint.Y + 50)
            };
            foxDraw.DrawPolygon(pointlist);
        }
    }
}
