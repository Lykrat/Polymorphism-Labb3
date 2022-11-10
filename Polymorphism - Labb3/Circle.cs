using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism___Labb3
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public const double Pi = 3.14;

        public Circle()
        {
            Radius = 5;
        }
        public Circle(double _radius)
        {
            Radius = _radius;
        }
        public override double Area()
        {
            return Radius * Radius * Pi;
        }
    }
}
