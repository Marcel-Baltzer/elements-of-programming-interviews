namespace Elements_of_Programming_Interviews._03._Strings._13._FindSubstring
{
    public class Solution
    {
        // Returns the index of the first character of  
        // the substring if found, -1 otherwise.
        public static int RabinKarp(string text, string sub)
        {
            if(sub.Length > text.Length)
            {
                return -1; // sub is not a substring of text.
            }

            int @base = 26;

            // Hash codes for the substring of text and sub.
            int textHash = 0;
            int subHash = 0;
            int powerS = 1; // BASE^|s| 

            for(int i = 0; i < sub.Length; i++)
            {
                powerS = i > 0 ? powerS * @base : 1;
                textHash = textHash * @base + text[i];
                subHash = subHash * @base + sub[i];
            }

            for(int i = sub.Length; i < text.Length; i++)
            {
                // Checks the two substrings are actually equal or not, 
                // to protect against hash collision.
                if(textHash == subHash && text.Substring(i - sub.Length, sub.Length).Equals(sub))
                {
                    return i - sub.Length; // Found a match.
                }

                // Uses rolling hash to compute the new hash code.
                textHash -= text[i - sub.Length] * powerS;
                textHash = textHash * @base + text[i];
            }

            // Tries to match sub and text.Substring(text.Length() - sub.Length).
            if(textHash == subHash && text.Substring(text.Length - sub.Length).Equals(sub))
            {
                return text.Length - sub.Length;
            }

            return -1; // sub is not a substring of text.
        }
    }
}