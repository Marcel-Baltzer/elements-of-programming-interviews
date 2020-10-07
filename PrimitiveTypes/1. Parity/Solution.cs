namespace Elements_of_Programming_Interviews.PrimitiveTypes.Parity
{
    public class Solution
    {
        public static short BruteForce(long number)
        {
            long result = 0;

            while (number > 0)
            {
                result ^= (number & 1);
                number >>= 1;
            }

            return (short)result;
        }


        public static short Parity(long number)
        {
            short result = 0;

            while (number > 0)
            {
                result ^= 1;
                number &= number - 1; // Drops the lowest set bit of number
            }

            return result;
        }

        public static short ParityWithChache(long number)
        {
             
            var wordSize = 16;
            var bitMask = 0xFFFF;

            var precomputedParity = new short[1 << wordSize];

            for (int i = 0; i < (1 << wordSize); ++i) 
            {
                precomputedParity[i] = Parity(i);
            } 

            var result = (short)(
                precomputedParity[(int)((number >> (3 * wordSize)) & bitMask)]
                ^ precomputedParity[(int)((number >> (2 * wordSize)) & bitMask)]
                ^ precomputedParity[(int)((number >> wordSize) & bitMask)]
                ^ precomputedParity[(int)(number & bitMask)]);

            return result;
        }

        public static short ParityWithXor(long number)
        {
            number ^= number >> 32;
            number ^= number >> 16;
            number ^= number >> 8;
            number ^= number >> 4;
            number ^= number >> 2;
            number ^= number >> 1;

            return (short)(number & 0x1);
        }
    }
}