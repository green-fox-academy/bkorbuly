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

namespace Exercise_04
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            int coordinates1 = rnd.Next(0, 301);
            int coordinates2 = rnd.Next(0, 301);
            var foxDraw = new FoxDraw(canvas);
            var point = new Point(15 , 15);
            var point2 = new Point(85 , 15);
            var point3 = new Point(coordinates1 ,coordinates2);
            var pointmid = new Point(150 , 150);
            LineDrawFunction(foxDraw, point, pointmid);
            LineDrawFunction(foxDraw, point2, pointmid);
            LineDrawFunction(foxDraw, point3, pointmid);
        }    
        public static void LineDrawFunction (FoxDraw canvas, Point start, Point middle)
        {

            canvas.DrawLine(start, middle);
        }
    }
}
