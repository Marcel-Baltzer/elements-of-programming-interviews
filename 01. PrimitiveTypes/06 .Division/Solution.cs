namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._06_.Division
{
    public class Solution
    {
        public static long Divide(long x, long y)
        {
            long result = 0;
            int power = 32;

            long yPower = y << power;

            while (x >= y)
            {
                while(yPower > x) 
                {
                    yPower >>= 1;
                    --power;
                }

                result += 1L << power;
                x -= yPower;
            }

            return result;
        }
    }
}