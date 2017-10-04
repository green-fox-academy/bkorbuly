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
        
        public int x = 0;
        public int y = 0;
        public int movx = 0;
        public int movy = 0;
        public int tileWidth = 50;
        public int tileHeight = 50;
        
        public void Display(string defaultImage, int x, int y)
        {
            foxdraw.AddImage(defaultImage, x, y);
        }
        
        public void MovementDisplay(int movx, int movy, string picture)
        {
            if( !MovementCheck(movx, movy))
            {
                foxdraw.AddImage(Tile.floorLocation, x * tileHeight, y * tileWidth);
                x += movx;
                y += movy;
                MovmentDraw(movx, movy, picture);
                
            }
        }

        public bool MovementCheck(int movx, int movy)
        {
            if ((x + movx) < 0 || (y + movy) < 0 ||
                (x + movx) > Tile.matrix.GetLength(0) - 1 || (y + movy) > Tile.matrix.GetLength(1) - 1 ||
                Tile.matrix[x + movx, y + movy])
            {
                return true;
            }
            return false;
        }

        public void MovmentDraw(int movx, int movy, string picture)
        {                
                if (x > x + movx)
                {
                    foxdraw.AddImage(picture, x * tileHeight, y * tileWidth);
                }
                else if (x < x + movx)
                {
                    foxdraw.AddImage(picture, x * tileHeight, y * tileWidth);
                }
                else if (y > y + movy)
                {
                    foxdraw.AddImage(picture, x * tileHeight, y * tileWidth);
                }
                else
                {
                    foxdraw.AddImage(picture, x * tileHeight, y * tileWidth);
                }

        }
    }
}
