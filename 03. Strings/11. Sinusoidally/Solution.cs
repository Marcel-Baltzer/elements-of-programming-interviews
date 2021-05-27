using System.Text;

namespace Elements_of_Programming_Interviews._03._Strings._11._Sinusoidally
{
    public class Solution
    {
        public static string SnakeString(string s)
        {
            var result = new StringBuilder();

            // Outputs the first row, i.e., s[l], s[5], s[9], ...
            for(int i = 1; i < s.Length; i+=4)
            {
                result.Append(s[i]);
            }

            // Outputs the second row, i.e., s[0], s[2], s[4], ...
            for(int i = 0; i < s.Length; i+=2)
            {
                result.Append(s[i]);                
            }

            // Outputs the third row, i.e., s[3], s[7], s[ll], ...
            for(int i = 3; i < s.Length; i+=4)
            {
                result.Append(s[i]);                
            }

            return result.ToString();
        }
    }
}