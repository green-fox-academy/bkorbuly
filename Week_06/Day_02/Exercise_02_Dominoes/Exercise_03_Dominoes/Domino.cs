using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03_Dominoes
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino other)
        {
            return this.GetValues()[0].CompareTo(other.GetValues()[0]);
        }

        public int[] GetValues()
        {
            return Values;
        }


        
    }
}
