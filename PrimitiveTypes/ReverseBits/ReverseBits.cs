namespace Elements_of_Programming_Interviews.PrimitiveTypes.ReverseBits
{
    public class ReverseBits
    {
        public long WithBrutForceFor(long number, int lastIndex)
        {
            var swap = new SwapBits.SwapBits();

            int i = 0;
            int j = lastIndex;

            while (i < j) {
                number = swap.For(number, i, j);
                i++;
                j--;
            }

            return number;
        }

        public long For(long number){
             
            var wordSize = 16;
            var bitMask = 0xFFFF;            

            var precomputedReverse = new long[1 << wordSize];

            for (long i = 0; i < (1 << wordSize); i++) {
                precomputedReverse[i] = WithBrutForceFor(i, wordSize-1);
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