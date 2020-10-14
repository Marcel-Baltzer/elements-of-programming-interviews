namespace Elements_of_Programming_Interviews.Strings.BaseConversion
{
    public class Solution
    {
        public static string ConvertBase(string numAsString, int base1, int base2)
        {
            bool isNegative = numAsString.StartsWith("-");
            int numAsInt = 0;

            for (int i = (isNegative ? 1: 0); i < numAsString.Length; i++)
            {
                numAsInt *= base1;
                numAsInt += char.IsDigit(numAsString[i])
                            ? numAsString[i] - '0'
                            : numAsString[i] - 'A' + 10;
            }

            return (isNegative ? "-" : "")
                + (numAsInt == 0 ? "0" : ConsturctFromBase(numAsInt, base2));
        }

        private static string ConsturctFromBase(int numAsInt, int @base)
        {
            return numAsInt == 0
                ? ""
                : ConsturctFromBase(numAsInt / @base, @base)
                    + (char)(numAsInt % @base >= 10 ? 'A' + numAsInt % @base -10
                                                    : '0' + numAsInt % @base);
        }
    }
}