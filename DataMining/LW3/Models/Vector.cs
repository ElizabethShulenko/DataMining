using System;

namespace LW3.Models
{
    public class Vector
    {
        public long X { get; set; }
        public long Y { get; set; }

        public Vector(long x, long y)
        {
            X = x;
            Y = y;
        }

        public Vector()
        {
            new Vector(0, 0);
        }

        public double Distance(Vector vector)
        {
            var xPowed = Math.Pow((X - vector.X), 2);
            var yPowed = Math.Pow((Y - vector.Y), 2);

            return xPowed + yPowed;
        }

        public void Add(Vector vector)
        {
            X += vector.X;
            Y += vector.Y;
        }
    }
}
