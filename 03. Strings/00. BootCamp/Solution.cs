namespace Elements_of_Programming_Interviews._03._Strings._00._BootCamp
{
    public class Solution
    {
        public static bool IsPalindromic(string s)
        {
            for(int i = 0, j = s.Length-1; i <j; i++,j--)
            {
                if(s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}