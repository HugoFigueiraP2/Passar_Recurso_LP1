using System;

namespace Interface_Ex1
{
    public class Circle : IShape
    {
        public double Radius {get; set;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 *  Math.PI * Radius;
        }
    }
}