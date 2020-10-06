using System;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ClosestIntergerWithSameWeight
{
    public class ClosestIntWithSameBitCount
    {
        private const int NUM_UNSIGN_BITS = 63;

        public long For(long number)
        {
            for (int i = 0; i < NUM_UNSIGN_BITS -1; ++i)
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