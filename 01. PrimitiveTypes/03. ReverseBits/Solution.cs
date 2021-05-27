namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._03._ReverseBits
{
    public class Solution
    {
        public static long BrutForce(long number, int lastIndex)
        {   
            int i = 0;
            int j = lastIndex;

            while (i < j) 
            {
                number = _02._SwapBits.Solution.SwapBits(number, i, j);
                i++;
                j--;
            }

            return number;
        }

        public static long ReverseBits(long number)
        {             
            var wordSize = 16;
            var bitMask = 0xFFFF;            

            var precomputedReverse = new long[1 << wordSize];

            for (long i = 0; i < (1 << wordSize); i++) 
            {
                precomputedReverse[i] = BrutForce(i, wordSize-1);
            } 

            var result =
                ((precomputedReverse[number & bitMask] << (3 * wordSize))
                | (precomputedReverse[(number >> wordSize) & bitMask] << (2 * wordSize))
                | (precomputedReverse[(number >> (2 * wordSize)) & bitMask] << wordSize)
                | (precomputedReverse[(number >> (3 * wordSize)) & bitMask]));

            return result;
        }
    }
}