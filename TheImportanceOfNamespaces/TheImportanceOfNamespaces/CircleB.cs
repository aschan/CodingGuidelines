namespace Outer.Inner
{
    using System;

    public class CircleB : ICircle
    {
        public CircleB(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double Circumference => 2 * Math.PI * Radius;

        public double Area => Math.PI * Radius * Radius;
    }
}
