using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpG
{
    class Hero : Characters
    {
        public string heroLocation;
        public string heroLocationDown = @"./Asset/hero-down.png";
        public string heroLocationLeft = @"./Asset/hero-left.png";
        public string heroLocationRight = @"./Asset/hero-right.png";
        public string heroLocationUp = @"./Asset/hero-up.png";
        public static int counter = 0;

        public Hero()
        {
            Display(heroLocationDown, 0, 4);
        }

        public void HeroMovement(int movx, int movy)
        {
            if (movx < 0)
            {
                heroLocation = heroLocationLeft;
            }
            else if (movx > 0)
            {
                heroLocation = heroLocationRight;
            }
            else if (movy < 0)
            {
                heroLocation = heroLocationUp;
            }
            else
            {
                heroLocation = heroLocationDown;
            }           
            MovementDisplay(movx, movy, heroLocation);
            counter++;
        }

    }
}
