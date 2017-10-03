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
using System.IO;
using GreenFox;

namespace RpG
{
    public class Tile : Map
    {
        public void DrawTiles()
        {
            string floor = @"./Asset/floor.png";
            Console.WriteLine(File.Exists(floor));
            for(int i = 0; i < 10; i++)
            {
                foxdraw.AddImage(floor, 0, 0);
            }
            
        }
    }
}
