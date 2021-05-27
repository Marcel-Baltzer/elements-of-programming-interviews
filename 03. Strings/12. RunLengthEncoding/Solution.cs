using System.Text;

namespace Elements_of_Programming_Interviews._03._Strings._12._RunLengthEncoding
{
    public class Solution
    {
        public static string Decoding(string s)
        {
            var count = 0;
            var result = new StringBuilder();

            for(var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if(char.IsDigit(c))
                {
                    count = count * 10 + c - '0';
                }
                else
                {
                    // c is a letter of alphabet.
                    while (count > 0)
                    {
                        // Appends count copies of c to result.
                        result.Append(c);
                        count--;
                    }
                }
            }

            return result.ToString();
        }

        public static string Encoding(string s)
        {
            var count = 1;
            var result = new StringBuilder();

            for(var i = 1; i <= s.Length; i++)
            {
                if(i == s.Length || s[i] != s[i-1])
                {
                    // Found new character so write the count of previous character.
                    result.Append(count);
                    result.Append(s[i-1]);
                    count = 1;
                }
                else
                {
                    // s[i] == s[i - 1].
                    count++;
                }
            }

            return result.ToString();
        }
    }
}