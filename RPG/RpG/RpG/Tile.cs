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

namespace RpG
{
    public class Tile : Map
    {
        public void DrawTiles()
        {
            string floor = @"C:\Users\Balazs\Greenfox\RPG\RpG\RpG\Asset\floor.png";
            for(int i = 0; i < 10; i++)
            {
                //foxdraw.BackgroundColor(Colors.AliceBlue);
                Point p1 = new Point(12, 123);
                Point p2 = new Point(150, 123);
                foxdraw.DrawLine(p1, p2);
                foxdraw.AddImage(floor, 10, 10);
            }
            
        }
    }
}
