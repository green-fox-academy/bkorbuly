using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02_Sum
{
    public class SUM
    {
        int sum;

        public int Summary(List<int> list)
        {
            foreach(int num in list)
            {
                sum += num;
            }
            return sum;
        }
       
    }
}
