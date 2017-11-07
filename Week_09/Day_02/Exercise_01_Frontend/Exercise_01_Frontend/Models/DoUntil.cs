using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_01_Frontend.Models
{
    public class DoUntil
    {
        public int Number { get; set; }

        public int Sum()
        {
            if (Number == 0)
            {
                return 0;
            }
            return Number-- + Sum();
        }
        public int Factor()
        {
            if (Number == 0)
            {
                return 1;
            }
            return Number-- * Factor();
        }
    }
}
