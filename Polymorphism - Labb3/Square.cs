using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism___Labb3
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 5;
        }
        public Square(double _side)
        {
            Side = _side;
        }
        public override double Area()
        {
            return Side*Side;
        }
    }
}
