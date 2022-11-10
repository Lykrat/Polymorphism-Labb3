using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Polymorphism___Labb3
{
    internal class Rectangle : Geometry
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle()
        {
            Side1 = 5;
            Side2 = 3;
        }
        public Rectangle(double _side1,double _side2)
        {
            Side1 = _side1;
            Side2 = _side2;
        }
        public override double Area()
        {
            return Side1 * Side2;
        }
    }
}
