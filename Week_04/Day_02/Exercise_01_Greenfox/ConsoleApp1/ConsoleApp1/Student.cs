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

        public void PrintOut()
        {
            Console.WriteLine("{0},{1}",  previousOrganization, skippedDays);
        }
    }

    

}
