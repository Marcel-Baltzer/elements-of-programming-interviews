namespace Elements_of_Programming_Interviews._12._Recursion._00._BootCamp
{
    public class Solution
    {
        public static long GreatestCommonDivisor(long x, long y)
        {
            return y == 0 ? x : GreatestCommonDivisor(y, x % y);
        }
    }
}