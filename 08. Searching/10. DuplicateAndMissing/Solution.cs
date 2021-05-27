using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._10._DuplicateAndMissing
{
    public class Solution
    {
        public class DuplicateAndMissing
        {
            public readonly int Duplicate;
            public readonly int Missing;

            public DuplicateAndMissing(int duplicate, int missing)
            {
                Duplicate = duplicate;
                Missing = missing;
            }
        }

        public static DuplicateAndMissing FindDuplicateMissing(List<int> array)
        {
            // Compute the XOR of all numbers from 0 to |A| - 1 and all entries in A.
            var missXorDup = 0;
            for (var i = 0; i < array.Count; ++i)
            {
                missXorDup ^= i ^ array[i];
            }

            // We need to find a bit that’s set to 1 in missXORDup. Such a bit
            // must exist if there is a single missing number and a single duplicated
            // number in A.
            //
            // The bit-fiddling assignment below sets all of bits in differBit to 0
            // except for the least significant bit in missXORDup that’s 1.
            var differBit = missXorDup & (~(missXorDup - 1));
            var missOrDup = 0;

            for (var i = 0; i < array.Count; ++i)
            {
                // Focus on entries and numbers in which the differBit-th bit is 1.
                if ((i & differBit) != 0)
                {
                    missOrDup ^= i;
                }

                if ((array[i] & differBit) != 0)
                {
                    missOrDup ^= array[i];
                }
            }

            // missOrDup is either the missing value or the duplicated entry.
            foreach (var a in array)
            {
                if (a == missOrDup) // missOrDup is the duplicate.
                {
                    return new DuplicateAndMissing(missOrDup, missOrDup ^ missXorDup);
                }
            }

            // missOrDup is the missing value.
            return new DuplicateAndMissing(missOrDup ^ missXorDup, missOrDup);
        }
    }
}