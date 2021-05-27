using System;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._04._ClosestIntegerWithSameWeight
{
    public class Solution
    {
        private const int NumUnsignedBits = 63;

        public static long ClosestIntWithSameBitCount(long number)
        {
            for (var i = 0; i < NumUnsignedBits -1; ++i)
            {
                if ( ((number >> 1) & 1) != ((number >> (i+1)) & 1))
                {
                    number ^= (1 << i) | (1 << (i+1));
                    return number;
                } 
            }

            throw new ArgumentException ("All bits are 0 or 1"); 
        }
    }
}