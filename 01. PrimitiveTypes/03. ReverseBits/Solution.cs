namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._03._ReverseBits
{
    public class Solution
    {
        public static long BrutForce(long number, int lastIndex)
        {   
            var i = 0;
            var j = lastIndex;

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
            const int wordSize = 16;
            const int bitMask = 0xFFFF;            

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