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
        public string heroLocationLeft = @"./Asset/hero-left.png";
        public string heroLocationRight = @"./Asset/hero-right.png";
        public string heroLocationUp = @"./Asset/hero-up.png";
        int x = 0;
        int y = 0;
        int tileWidth = 50;
        int tileHeight = 50;
        int movx = 0;
        int movy = 0;

        public void DisplayHero()
        {
            foxdraw.AddImage(heroLocation, x, y);
        }

        public void MovementHero(int movx, int movy)
        {            
            if ( (x + movx) < 0 || (y + movy) < 0 ||
                (x + movx) > Tile.matrix.GetLength(0)-1 || (y + movy) > Tile.matrix.GetLength(1)-1  ||
                Tile.matrix[x + movx, y + movy])
            {
                return;
            }
            else
            {
                DisplayCorrectDirections(movx, movy);
            }
        }

        public void DisplayCorrectDirections(int movx, int movy)
        {
            foxdraw.AddImage(Tile.floorLocation, x * tileHeight, y * tileWidth);
            if (x > x + movx )
            {
                x += movx;
                foxdraw.AddImage(heroLocationLeft, x * tileHeight, y * tileWidth);
                return;
            }
            else if (x < x + movx)
            {
                x += movx;
                foxdraw.AddImage(heroLocationRight, x * tileHeight, y * tileWidth);
            }
            else if (y > y + movy)
            {
                y += movy;
                foxdraw.AddImage(heroLocationUp, x * tileHeight, y * tileWidth);
            }
            else
            {
                y += movy;
                foxdraw.AddImage(heroLocation, x * tileHeight, y * tileWidth);
            }
        }
    }
}
