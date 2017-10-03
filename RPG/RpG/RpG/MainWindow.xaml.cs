﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();
            Map.Canvas = canvas;
            Tile tile = new Tile();
            Characters hero = new Characters();
            tile.FillMatrix();
            hero.DisplayHero();
            
        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right!");
            }
        }
    }
}
