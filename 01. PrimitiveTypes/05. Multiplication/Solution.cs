namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._05._Multiplication
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
            long carryIn = 0;
            long k = 1;
            var tempA = a;
            var tempB = b;

            while (tempA != 0 || tempB != 0)
            {
                var ak = a & k;
                var bk = b & k;

                var carryout = (ak & bk) | (ak & carryIn) | (bk & carryIn);

                sum |= (ak ^ bk ^ carryIn);
                carryIn = carryout << 1;
                k <<= 1;
                tempA >>= 1;
                tempB >>= 1;
            }

            return sum | carryIn;
        }   
    }
}