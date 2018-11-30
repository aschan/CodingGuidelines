using System;

namespace Outer.Inner
{
    public class CircleA : ICircle
    {
        public CircleA(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double Circumference => 2 * Math.PI * Radius;

        public double Area => Math.PI * Radius * Radius;
    }
}
