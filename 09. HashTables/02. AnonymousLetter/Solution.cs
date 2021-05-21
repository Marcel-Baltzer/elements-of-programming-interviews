using System.Collections.Generic;
using Castle.Core.Internal;

namespace Elements_of_Programming_Interviews.HashTables.AnonymousLetter
{
    public class Solution
    {
        public static bool IsLetterConstructibleFromMagazine(string letterText, string magazineText)
        {
            var charFrequencyForLetter = new Dictionary<char, int>();
            
            // Compute the frequencies for all chars in letterText.
            for (var i = 0; i < letterText.Length; i++)
            {
                var c = letterText[i];
                if (!charFrequencyForLetter.ContainsKey(c))
                {
                    charFrequencyForLetter[c] = 1;
                }
                else
                {
                    charFrequencyForLetter[c] = charFrequencyForLetter[c] + 1;
                }
            }
            
            // Check if the characters in magazineText can cover characters in
            // letterText.
            foreach (var c in magazineText.ToCharArray())
            {
                if (charFrequencyForLetter.ContainsKey(c))
                {
                    charFrequencyForLetter[c] = charFrequencyForLetter[c] - 1;
                    if (charFrequencyForLetter[c] == 0)
                    {
                        charFrequencyForLetter.Remove(c);
                        // All characters for letterText are matched.
                        if (charFrequencyForLetter.IsNullOrEmpty())
                        {
                            break;
                        }
                    }
                }
            }
            // Empty charFrequencyForLetter means every char in letterText can be
            // covered by a character in magazineText.
            return charFrequencyForLetter.IsNullOrEmpty();
        }
    }
}