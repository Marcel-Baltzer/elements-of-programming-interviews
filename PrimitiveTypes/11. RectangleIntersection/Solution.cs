using System;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.RectangleIntersection
{
    public static class Solution
    {
        public  class Rectangle
        {
            public int x { get; private set; }
            public int y { get; private set; }
            public int width { get; private set; }
            public int height { get; private set; }

            public Rectangle(int x, int y, int width, int height)
            {
                this.x  = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }

        public static Rectangle IntersectRectangle(Rectangle R1, Rectangle R2)
        {
            if (!IsIntersect(R1 , R2))
            {
                return new Rectangle(0, 0, -1, -1); // No intersection
            }

            return new Rectangle(
                Math.Max(R1.x , R2.x),
                Math.Max(R1.y , R2.y),
                Math.Min(R1.x + R1.width, R2.x + R2.width) - Math.Max(R1.x , R2.x),
                Math.Min(R1.y + R1.height, R2.y + R2.height) - Math.Max(R1.y , R2.y)
            );
        }


        public static bool IsIntersect(Rectangle R1, Rectangle R2)
        {
            return R1.x <= R2.x + R2.width &&
                   R1.x + R1.width >= R2.x &&
                   R1.y <= R2.y + R2.height &&
                   R1.y + R1.height >= R2.y;
        }
        
    }
}