using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        string name;
        int age;
        string gender;

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
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}", name, age, gender);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
