using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpG
{
    class Characters : Map
    {
        public void DisplayHero()
        {
            foxdraw.AddImage(@".'\Asset\hero-down.png", 0, 0);
        }
    }
}
