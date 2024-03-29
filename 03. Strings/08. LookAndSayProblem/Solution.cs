using System.Text;

namespace Elements_of_Programming_Interviews._03._Strings._08._LookAndSayProblem
{
    public class Solution
    {
        public static string LookAndSay(int n)
        {
            var s = "1";

            for(var i = 1; i < n; i++)
            {
                s = NextNumber(s);
            }

            return s;
        }

        private static string NextNumber(string s)
        {
            var result = new StringBuilder();

            for(var i = 0; i < s.Length; i++)
            {
                var count = 1;
                while(i+1 < s.Length && s[i] == s[i+1])
                {
                    i++;
                    count++;
                }
                result.Append(count);
                result.Append(s[i]);
            }

            return result.ToString();
        }
    }
}