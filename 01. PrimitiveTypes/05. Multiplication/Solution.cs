namespace Elements_of_Programming_Interviews.PrimitiveTypes.Multiplication
{
    public class Solution
    {
        public static long Multiply(long x, long y)
        {
            long sum = 0;

            while(x != 0) 
            {
                if((x & 1) != 0)
                {
                    sum = Add(sum, y);
                }
                x >>= 1;
                y <<= 1;
            }

            return sum;
        }

        private static long Add(long a, long b)
        {
            long sum = 0;
            long carryin = 0;
            long k = 1;
            long temp_a = a;
            long temp_b = b;

            while (temp_a != 0 || temp_b != 0)
            {
                long ak = a & k;
                long bk = b & k;

                long carryout = (ak & bk) | (ak & carryin) | (bk & carryin);

                sum |= (ak ^ bk ^ carryin);
                carryin = carryout << 1;
                k <<= 1;
                temp_a >>= 1;
                temp_b >>= 1;
            }

            return sum | carryin;
        }   
    }
}