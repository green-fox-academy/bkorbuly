using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Balazs", 30, "male", "life");
            student.Introduce();
            Console.ReadLine();
        }
    }
}
