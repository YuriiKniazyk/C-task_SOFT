using System;

namespace CW10UnitTesting
{
    public class Triangle
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Point P3 { get; set; }

        public Triangle(Point a, Point b, Point c)
        {
            P1 = a;
            P2 = b;
            P3 = c;
        }

        public double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y- a.Y, 2));
        }

        public double Perimeter(Point a, Point b, Point c)
        {
            return Distance(a, b) + Distance(a, c) + Distance(b, c);
        }

        public string Print ()
        {
            return $"Perimeter Triangle: {Perimeter(P1, P2, P3)}";
        }
    }
}