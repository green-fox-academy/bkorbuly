using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mentor : Person
    {
        string level;

        public Mentor() : base()
        {
            level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level) :base(name, age, gender)
        {
            this.level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers");
        }

        public new void Introduce()
        {
            base.Introduce();
            Console.WriteLine("{0} mentor");
        }
    }
}
