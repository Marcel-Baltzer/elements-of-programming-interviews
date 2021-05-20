using System.Collections;
using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.Searching.MissingIPAddress
{
    public class Solution
    {
        private static readonly int NUM_BUCKET = 1 << 16;

        public static int FindMissingElement(IEnumerator<int> sequence)
        {
            int[] counter = new int[NUM_BUCKET];

            while (sequence.MoveNext())
            {
                int idx = (int)((uint)sequence.Current >> 16);
                ++counter[idx];
            }

            for (int i = 0; i < counter.Length; ++i)
            {
                // Look for a bucket that contains less than NUN_BUCKET elements.
                if (counter[i] < NUM_BUCKET)
                {
                    var bitVec = new BitArray(NUM_BUCKET);
                    // Search from the beginning again.
                    sequence.Reset();
                    while (sequence.MoveNext())
                    {
                        int x = sequence.Current;
                        if (i == (int)((uint)x >> 16))
                        {
                            // Gets the lower 16 bits of x.
                            bitVec.Set(((NUM_BUCKET) - 1) & x, true);
                        }
                    }

                    for (int j = 0; j < (1 << 16); ++j)
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