using System;
using System.Runtime.CompilerServices;

namespace GeometryLibrary
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Radius cannot be negative.");

            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

    public class Triangle : IShape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("Sides of the triangle must be positive.");

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            return Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
        }

        public bool IsRightTriangle()
        {
            return Math.Abs(Math.Max(Math.Max(a * a, b * b), c * c) - Math.Min(Math.Min(a * a, b * b), c * c) -
                            ((a * a + b * b + c * c) - Math.Max(Math.Max(a * a, b * b), c * c) -
                             Math.Min(Math.Min(a * a, b * b), c * c))) < 0.0001;
        }
    }
}