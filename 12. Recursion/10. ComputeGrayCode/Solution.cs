using System.Collections.Generic;
using System.Linq;

namespace Elements_of_Programming_Interviews._12._Recursion._10._ComputeGrayCode
{
    public static class Solution
    {
        // Solution One.
        public static IEnumerable<int> GrayCode(int numBits)
        {
            var result = new List<int> {0};
            DirectedGrayCode(numBits, new HashSet<int>(new List<int> {0}), result);
            return result;
        }

        private static bool DirectedGrayCode(int numBits, ISet<int> history, ICollection<int> result)
        {
            if (result.Count == (1 << numBits))
            {
                return DiffersByOneBit(result.First(), result.Last());
            }

            for (var i = 0; i < numBits; i++)
            {
                var previousCode = result.Last();
                var candidateNextCode = previousCode ^ (1 << i);

                if (!history.Contains(candidateNextCode))
                {
                    history.Add(candidateNextCode);
                    result.Add(candidateNextCode);
                    if (DirectedGrayCode(numBits, history, result))
                    {
                        return true;
                    }

                    history.Remove(candidateNextCode);
                    result.Remove(result.Last());
                }
            }

            return false;
        }

        private static bool DiffersByOneBit(int x, int y)
        {
            var bitDifference = x ^ y;
            return bitDifference != 0 && (bitDifference & (bitDifference - 1)) == 0;
        }

        // Solution Two.
        public static List<int> GrayCodeTwo(int numBits)
        {
            if (numBits == 0)
            {
                return new List<int> {0};
            }

            // These implicitly begin with ® at bit-index (numBits - 1).
            var grayCodeNumBitsMinusOne = GrayCodeTwo(numBits - 1);

            // Now, add a 1 at bit-index (numBits - 1) to all entries in
            // grayCodeNumBitsMinusOne.
            var leadingBitOne = 1 << (numBits - 1);
            // Process in reverse order to achieve reflection of grayCodeNumBitsMinusOne.
            for (var i = grayCodeNumBitsMinusOne.Count - 1; i >= 0; i--)
            {
                grayCodeNumBitsMinusOne.Add(leadingBitOne | grayCodeNumBitsMinusOne[i]);
            }

            return grayCodeNumBitsMinusOne;
        }
    }
}