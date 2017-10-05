using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string text = "\nMy goal is:";

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public Person(string names, int age, string gender)
        {
            this.name = names;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.Write("Hi, I'm {0}, a {1} year old {2}. ", name, age, gender);
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("{0} Live for the moment.", text);
        }
    }
}
