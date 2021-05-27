using System.Collections;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._08._Searching._09._MissingIPAddress
{
    public class Solution
    {
        private const int NumBucket = 1 << 16;

        public static int FindMissingElement(IEnumerator<int> sequence)
        {
            var counter = new int[NumBucket];

            while (sequence.MoveNext())
            {
                var idx = (int)((uint)sequence.Current >> 16);
                ++counter[idx];
            }

            for (var i = 0; i < counter.Length; ++i)
            {
                // Look for a bucket that contains less than NUN_BUCKET elements.
                if (counter[i] < NumBucket)
                {
                    var bitVec = new BitArray(NumBucket);
                    // Search from the beginning again.
                    sequence.Reset();
                    while (sequence.MoveNext())
                    {
                        var x = sequence.Current;
                        if (i == (int)((uint)x >> 16))
                        {
                            // Gets the lower 16 bits of x.
                            bitVec.Set(((NumBucket) - 1) & x, true);
                        }
                    }

                    for (var j = 0; j < (1 << 16); ++j)
                    {
                        if (!bitVec.Get(j))
                        {
                            return (i << 16) | j;
                        }
                    }
                }
            }
            return int.MinValue;
        }
    }
}