using System;

namespace CSharpSixReview
{
    public class PrimaryConstructor(int x, int y)
    {
        public readonly int Base;

        public int X { get; } = x;
        public int Y { get; } = y;

        public override string ToString()
        {
            return X + ":" + Y;
        }

        {
            Base = 12;

            if (x > 100)
            {
                throw new ArgumentException();
            }
        }
    }
}
