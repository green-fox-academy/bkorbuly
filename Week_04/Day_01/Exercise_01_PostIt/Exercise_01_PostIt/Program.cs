using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Exercise_01_PostIt
{
    class Program
    {
        struct PostIt
        {
            public ConsoleColor Background;
            public string Text;
            public ConsoleColor Textcolor;
        }


        static void Main(string[] args)
        {
            PostIt examples, examples1, examples2;
            examples.Background = ConsoleColor.Blue;
            examples.Text = "Idea 1";
            examples.Textcolor = ConsoleColor.Black;

            Console.BackgroundColor = examples.Background;
            Console.ForegroundColor = examples.Textcolor;
            Console.WriteLine(examples.Text);

            Console.ReadLine();

        }
    }
}
