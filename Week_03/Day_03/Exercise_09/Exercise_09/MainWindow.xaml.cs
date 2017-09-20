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

namespace Exercise_09
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            var foxDraw = new FoxDraw(canvas);
            var middlepoint = new Point(150, 150);
            int squaresize = 150;
            DrawSquare(foxDraw, middlepoint, squaresize);
            foxDraw.FillColor(Colors.Aqua);
            DrawSquare(foxDraw, middlepoint, rnd.Next(51, 120));
            foxDraw.FillColor(Colors.LightPink);
            DrawSquare(foxDraw, middlepoint, rnd.Next(0 , 50));

        }

        private void DrawSquare(FoxDraw foxDraw, Point middlepoint, int squaresize)
        {
            var squarepoints = new List<Point>()
            {
                new Point(middlepoint.X - squaresize , middlepoint.Y - squaresize),
                new Point(middlepoint.X + squaresize , middlepoint.Y - squaresize),
                new Point(middlepoint.X + squaresize , middlepoint.Y + squaresize),
                new Point(middlepoint.X - squaresize , middlepoint.Y + squaresize),
            };
            foxDraw.DrawPolygon(squarepoints);

        }
    }
}
