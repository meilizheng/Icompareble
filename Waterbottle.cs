using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icompareble
{
    internal class Waterbottle : IComparable<Waterbottle>  //creat a water bottle class inherentance from Icomparable waterbottle;
    {
        double _Price; //created the field;
        string _Material;
        int _Capacity;
        string _Shape;

        public Waterbottle(double price, string material, int capacity, string shape) //created the constructors;
        {
            _Price = price;
            _Material = material;
            _Capacity = capacity;
            _Shape = shape;
        }

        public double Price { get => _Price; set => _Price = value; }  //created the properties;
        public string Material { get => _Material; set => _Material = value; }
        public int Capacity { get => _Capacity; set => _Capacity = value; }
        public string Shape { get => _Shape; set => _Shape = value; }

        public int CompareTo(Waterbottle other)  //compare the capacity;
        {
            if (this._Capacity < other._Capacity)
            {
                return -1;
            }
            else if (this._Capacity > other._Capacity)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()  //use override tostring to display result;
        {
            return $"${_Price} - {_Material} - {_Capacity}OZ - {_Shape}";
        }
    }
}
