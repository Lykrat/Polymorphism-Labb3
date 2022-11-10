using System;

namespace Polymorphism___Labb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle1 = new Rectangle(5,7.5);
            Console.WriteLine("Area for Rectangle:{0}cm\xB2", rectangle1.Area());

            Geometry square1 = new Square(4);
            Console.WriteLine("Area for Sqaure:{0}cm\xB2", square1.Area());

            Geometry circle1 = new Circle(4);
            Console.WriteLine("Area for Circle:{0}cm\xB2", circle1.Area());
        }
    }
}
