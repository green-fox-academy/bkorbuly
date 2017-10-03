using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpG
{
    class Characters : Map
    {
        public string heroLocation = @"./Asset/hero-down.png";

        public void DisplayHero()
        {
            foxdraw.AddImage(heroLocation, 0, 0);
        }
    }
}
