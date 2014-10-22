using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;


namespace CSharpSixReview.StructConstructor
{
    struct Vector2D(double x, double y)
    {
        public double X { get; } = x;
        public double Y { get; } = y;

        public double Length => Sqrt(X * X + Y * Y);

        public Vector2D() : this(0.0, 1.0)
        {

        }

        public static Vector2D operator +(Vector2D first, Vector2D second) => 
            new Vector2D(first.X + second.X, first.Y + second.Y);

        public override string ToString() => string.Format("({0},{1})", X, Y);
    }
}
