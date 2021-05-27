namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._07._Exponentiation
{
    public class Solution
    {
        public static double Power(double  basis, int exponent)
        {
            var result = 1.0;
            long power = exponent;

            if(exponent < 0)
            {
                power = -power;
                basis = 1.0 /basis;
            }

            while (power != 0) 
            {
                if((power & 1) != 0)
                {
                    result *= basis;
                }

                basis *= basis;
                power >>= 1;
            }

            return result;
        }
    }
}