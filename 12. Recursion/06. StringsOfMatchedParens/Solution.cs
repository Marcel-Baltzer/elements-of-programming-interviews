using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._12._Recursion._06._StringsOfMatchedParens
{
    public static class Solution
    {
        public static IEnumerable<string> GenerateBalancedParentheses(int numPairs)
        {
            var result = new List<string>();
            DirectedGenerateBalancedParentheses(numPairs, numPairs,
                string.Empty, result);

            return result;
        }

        private static void DirectedGenerateBalancedParentheses(int numLeftParensNeeded, int numRightParensNeeded,
            string validPrefix, ICollection<string> result)
        {
            if (numLeftParensNeeded == 0 && numRightParensNeeded == 0)
            {
                result.Add(validPrefix);
                return;
            }

            if (numLeftParensNeeded > 0) // Able to insert '('.
            {
                DirectedGenerateBalancedParentheses(numLeftParensNeeded - 1, numRightParensNeeded,
                    validPrefix + "(", result);
            }

            if (numLeftParensNeeded < numRightParensNeeded) // Able to insert ')'.
            {
                DirectedGenerateBalancedParentheses(numLeftParensNeeded, numRightParensNeeded - 1,
                    validPrefix + ")", result);
            }
        }
    }
}