using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpG
{
    class Hero : Characters
    {
        public string heroLocation = @"./Asset/hero-down.png";
        public string heroLocationLeft = @"./Asset/hero-left.png";
        public string heroLocationRight = @"./Asset/hero-right.png";
        public string heroLocationUp = @"./Asset/hero-up.png";

        public Hero()
        {
            Display(heroLocation, x, y);
        }

        public void HeroMovement(int x, int y)
        {
            MovementDisplay(x, y, heroLocation);
        }

    }
}
