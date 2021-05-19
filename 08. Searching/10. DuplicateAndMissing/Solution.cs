using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.DuplicateAndMissing
{
    public class Solution
    {
        public class DuplicateAndMissing
        {
            public int Duplicate;
            public int Missing;

            public DuplicateAndMissing(int duplicate, int missing)
            {
                this.Duplicate = duplicate;
                this.Missing = missing;
            }
        }

        public static DuplicateAndMissing FindDuplicateMissing(List<int> A)
        {
            // Compute the XOR of all numbers from 0 to |A| - 1 and all entries in A.
            int missXORDup = 0;
            for (int i = 0; i < A.Count; ++i)
            {
                missXORDup ^= i ^ A[i];
            }

            // We need to find a bit that’s set to 1 in missXORDup. Such a bit
            // must exist if there is a single missing number and a single duplicated
            // number in A.
            //
            // The bit-fiddling assignment below sets all of bits in differBit to 0
            // except for the least significant bit in missXORDup that’s 1.
            int differBit = missXORDup & (~(missXORDup - 1));
            int missOrDup = 0;

            for (int i = 0; i < A.Count; ++i)
            {
                // Focus on entries and numbers in which the differBit-th bit is 1.
                if ((i & differBit) != 0)
                {
                    missOrDup ^= i;
                }

                if ((A[i] & differBit) != 0)
                {
                    missOrDup ^= A[i];
                }
            }

            // missOrDup is either the missing value or the duplicated entry.
            foreach (int a in A)
            {
                if (a == missOrDup) // missOrDup is the duplicate.
                {
                    return new DuplicateAndMissing(missOrDup, missOrDup ^ missXORDup);
                }
            }

            // missOrDup is the missing value.
            return new DuplicateAndMissing(missOrDup ^ missXORDup, missOrDup);

        }


    }
}