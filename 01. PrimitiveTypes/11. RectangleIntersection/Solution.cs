using System;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._11._RectangleIntersection
{
    public static class Solution
    {
        public  class Rectangle
        {
            public int X { get; }
            public int Y { get; }
            public int Width { get; }
            public int Height { get; }

            public Rectangle(int x, int y, int width, int height)
            {
                X  = x;
                Y = y;
                Width = width;
                Height = height;
            }
        }

        public static Rectangle IntersectRectangle(Rectangle r1, Rectangle r2)
        {
            if (!IsIntersect(r1 , r2))
            {
                return new Rectangle(0, 0, -1, -1); // No intersection
            }

            return new Rectangle(
                Math.Max(r1.X , r2.X),
                Math.Max(r1.Y , r2.Y),
                Math.Min(r1.X + r1.Width, r2.X + r2.Width) - Math.Max(r1.X , r2.X),
                Math.Min(r1.Y + r1.Height, r2.Y + r2.Height) - Math.Max(r1.Y , r2.Y)
            );
        }


        private static bool IsIntersect(Rectangle r1, Rectangle r2)
        {
            return r1.X <= r2.X + r2.Width &&
                   r1.X + r1.Width >= r2.X &&
                   r1.Y <= r2.Y + r2.Height &&
                   r1.Y + r1.Height >= r2.Y;
        }
        
    }
}