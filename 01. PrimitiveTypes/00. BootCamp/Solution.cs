namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._00._BootCamp
{
    public class Solution{

        public static int CountBits(int number)
        {            
            var numBits = 0;

            while (number > 0)
            {
                numBits += number & 1;
                number >>= 1;
            }

            return numBits;
        }
    }
}