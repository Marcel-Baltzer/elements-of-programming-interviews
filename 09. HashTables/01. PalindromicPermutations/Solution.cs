using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._09._HashTables._01._PalindromicPermutations
{
    public class Solution
    {
        public static bool CanFormPalindrome(string s)
        {
            var charFrequencies = new Dictionary<char, int>();
            
            // Compute the frequency of each char in s.
            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!charFrequencies.ContainsKey(c))
                {
                    charFrequencies[c] = 1;
                }
                else
                {
                    charFrequencies[c] = charFrequencies[c] + 1;
                }
            }
            
            // A string can be permuted as a palindrome if and only if the number of
            // chars whose frequencies is odd is at most 1.
            var oddCount = 0;
            foreach (var p in charFrequencies)
            {
                if((p.Value % 2) != 0 && ++oddCount > 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}