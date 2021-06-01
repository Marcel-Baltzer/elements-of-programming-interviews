using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._07._PalindromicDecompositions
{
    public static class Solution
    {
        public static IEnumerable<List<string>> PalindromePartitioning(string input)
        {
            var result = new List<List<string>>();
            DirectedPalindromePartitioning(input, 0, new List<string>(), result);
            return result;
        }

        private static void DirectedPalindromePartitioning(string input, int offset,
            IList<string> partialPartition, ICollection<List<string>> result)
        {
            if (offset == input.Length)
            {
                result.Add(new List<string>(partialPartition));
                return;
            }

            for (var i = offset + 1; i <= input.Length; ++i)
            {
                var prefix = input.Substring(offset, i - offset);

                if (IsPalindrome(prefix))
                {
                    partialPartition.Add(prefix);
                    DirectedPalindromePartitioning(input, i, partialPartition, result);
                    partialPartition.RemoveAt(partialPartition.Count - 1);
                }
            }
        }

        private static bool IsPalindrome(string prefix)
        {
            var j = prefix.Length - 1;
            for (var i = 0; i < j; ++i, --j)
            {
                if (prefix[i] != prefix[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}