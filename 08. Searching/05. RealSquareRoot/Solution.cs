namespace Elements_of_Programming_Interviews._08._Searching._05._RealSquareRoot
{
    public class Solution
    {
        public static double SquareRoot(double x)
        {
            // Decides the search range according to x’s value relative to 1.0.
            double left, right;

            if (x < 1.0)
            {
                left = x;
                right = 1.0;
            }
            else
            { // x >= 1.0.
                left = 1.0;
                right = x;
            }

            // Keeps searching as long as left < right , within tolerance.
            while (Compare(left, right) == Ordering.Smaller)
            {
                var mid = left + 0.5 * (right - left);
                var midSquared = mid * mid;
                if (Compare(midSquared, x) == Ordering.Equal)
                {
                    return mid;
                }
                else if (Compare(midSquared, x) == Ordering.Larger)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }
            return left;
        }

        private enum Ordering { Smaller, Equal, Larger }

        private static Ordering Compare(double a, double b)
        {
            const double epsilon = 0.00001;

            // Uses normalization for precision problem.
            var diff = (a - b) / b;

            return diff < -epsilon ? Ordering.Smaller : (diff > epsilon ? Ordering.Larger : Ordering.Equal);
        }
    }
}