using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icompareble
{
    internal class WaterbottleComparePrice : IComparer<Waterbottle>  //created a class to comapre the price;
    {
        public int Compare(Waterbottle x, Waterbottle y)
        {
            return x.Price.CompareTo (y.Price);
        }
    }
}
