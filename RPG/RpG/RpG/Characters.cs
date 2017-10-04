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
        static readonly Random rnd = new Random();
        public int x;
        public int y;
        public int tileWidth = 50;
        public int tileHeight = 50;
        
        public void Display(string defaultImage, int startpositionX, int startpositionY)
        {
            x = startpositionX;
            y = startpositionY;
            spawnCheck();
            foxdraw.AddImage(defaultImage, x * tileHeight, y * tileWidth);
        }
        
        public void MovementDisplay(int movx, int movy, string picture)
        {
            if( !MovementCheck(movx, movy))
            {
                foxdraw.AddImage(Tile.floorLocation, x * tileHeight, y * tileWidth);
                x += movx;
                y += movy;
                foxdraw.AddImage(picture, x * tileHeight, y * tileWidth);

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

        public int spawn()
        {
            return rnd.Next(0, 10);
        }

        public void spawnCheck()
        {
            while (Tile.matrix[x,y])
            {
                x = spawn();
                y = spawn();
            }
        }
    }
}
