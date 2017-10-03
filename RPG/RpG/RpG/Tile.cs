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
        public bool[,] matrix = new bool[10, 10];
        public string floorLocation = @"./Asset/floor.png";
        public string wallLocation = @"./Asset/wall.png";
        int tileWidth = 50;
        int tileHeight = 50;

        public bool[,] FillMatrix()
        {
            matrix[0, 4] = true;
            matrix[0, 5] = true;
            matrix[1, 4] = true;
            matrix[1, 5] = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    DrawTiles(matrix[i, j], i, j);                    
                }
            }
            
            return matrix;
            
        }
        public void DrawTiles(bool floorOrWall, int linePosition, int columnPosition)
        {
            if (floorOrWall)
            {
                foxdraw.AddImage(wallLocation, columnPosition*tileHeight, linePosition*tileWidth );
            }
            else
            {
                foxdraw.AddImage(floorLocation, columnPosition * tileHeight, linePosition * tileWidth);
            }
        }
    }
}
