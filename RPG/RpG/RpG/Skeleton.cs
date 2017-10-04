using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpG
{
    class Skeleton : Characters
    {
        string skeletonImg = @"./Asset/skeleton.png";
        public Skeleton()
        {
            Display(skeletonImg, 5, 5);
        }
    }
}
