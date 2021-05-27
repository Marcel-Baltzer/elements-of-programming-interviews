namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._00._BootCamp
{
    public class Solution{

        public static int CountBits(int number)
        {            
            var num_bits = 0;

            while (number > 0)
            {
                num_bits += number & 1;
                number >>= 1;
            }

            return num_bits;
        }
    }
}