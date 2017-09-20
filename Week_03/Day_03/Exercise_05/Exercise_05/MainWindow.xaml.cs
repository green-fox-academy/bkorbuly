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

namespace Exercise_05
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Random rnd = new Random();
            int coordinate1 = rnd.Next(0, 251);
            int coordinate2 = rnd.Next(0, 301);
            var pairstart = new Point(12 , 12);
            var pairstart2 = new Point(coordinate1, coordinate2);
            var pairstart3 = new Point(rnd.Next(0 , 251) , rnd.Next(0 , 301 ));
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            LineDraw(foxDraw , pairstart);
            LineDraw(foxDraw, pairstart2);
            LineDraw(foxDraw, pairstart3);
        }

        private void LineDraw(FoxDraw canvas, Point pairstart)
        {
           var pairend = new Point(pairstart.X + 50 , pairstart.Y);
           canvas.DrawLine(pairstart, pairend);
        }

    }
}
