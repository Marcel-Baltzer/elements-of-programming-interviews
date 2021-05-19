namespace Elements_of_Programming_Interviews.Searching.SquareRoot
{
    public class Solution
    {
        public static int SquareRoot(int k)
        {
            long left = 0;
            long right = k;
            // Candidate interval [left, right] where everything before left has
            // square <= k, and everything after right has square > k.
            while (left <= right)
            {
                long mid = left + ((right - left) / 2);
                long midSquared = mid * mid;

                if (midSquared <= k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return (int)left - 1;
        }
    }
}