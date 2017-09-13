using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "My todo:\n");
            todoText = todoText.Insert(todoText.Length, " - Download games");
            todoText = todoText.Insert(todoText.Length, "\n  - Diablo");

            Console.WriteLine(todoText);

            Console.ReadLine();
        }
    }
}
