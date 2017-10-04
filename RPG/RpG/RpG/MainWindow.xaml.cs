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
    public partial class MainWindow : Window
    {

        Characters hero;

        public MainWindow()
        {            
            InitializeComponent();
            Map.Canvas = canvas;
            hero = new Characters();
            Tile tile = new Tile();
            
            tile.FillMatrix();
            hero.DisplayHero();
        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
                hero.MovementHero(-1, 0);
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right!");
                hero.MovementHero(1,0);
            }

            if (e.Key == Key.Up)
            {
                Console.WriteLine("To the up!");
                hero.MovementHero(0, -1);
            }

            if (e.Key == Key.Down)
            {
                Console.WriteLine("To the down!");
                hero.MovementHero(0, 1);
            }
        }
    }
}
