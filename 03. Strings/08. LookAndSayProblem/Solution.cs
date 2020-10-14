using System.Text;

namespace Elements_of_Programming_Interviews.Strings.LookAndSayProblem
{
    public class Solution
    {
        public static string LookAndSay(int n)
        {
            string s = "1";

            for(int i = 1; i < n; i++)
            {
                s = NextNumber(s);
            }

            return s;
        }

        private static string NextNumber(string s)
        {
            var result = new StringBuilder();

            for(int i = 0; i < s.Length; i++)
            {
                int count = 1;
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