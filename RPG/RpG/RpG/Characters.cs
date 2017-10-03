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
    class Characters : Map
    {
        public string heroLocation = @"./Asset/hero-down.png";
        int x, y;
        int tileWidth = 50;
        int tileHeight = 50;

        public void DisplayHero()
        {
            x = 0;
            y = 0;
            foxdraw.AddImage(heroLocation, x, y);
        }

        public void MovementHero(int movx, int movy)
        {
            if (Tile.matrix[x+movx,y+movy])
            {
                return;
            }
            else
            {
                foxdraw.AddImage(Tile.floorLocation, x * tileHeight, y* tileWidth);
                x += movx;
                y += movy;                
                foxdraw.AddImage(heroLocation, (x) * tileHeight, (y)*tileWidth);
            }
        }
    }
}
