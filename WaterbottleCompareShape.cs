using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icompareble
{
    internal class WaterbottleCompareShape : IComparer<Waterbottle> //created a class to compare the shape;
    {
        public int Compare(Waterbottle x, Waterbottle y)
        {
           return x.Shape.CompareTo (y.Shape);
        }
    }
}
