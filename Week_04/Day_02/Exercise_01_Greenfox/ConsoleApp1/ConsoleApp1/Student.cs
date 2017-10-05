using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrganization) :base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("{0} Be a junior software developer", base.text);
        }

        public new void Introduce()
        {
            base.Introduce();
            Console.WriteLine(" from {0} who skipped {1} days from the course already.",
                previousOrganization, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }      
    }
}
