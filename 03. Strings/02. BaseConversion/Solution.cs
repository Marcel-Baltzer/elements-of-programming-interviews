namespace Elements_of_Programming_Interviews._03._Strings._02._BaseConversion
{
    public class Solution
    {
        public static string ConvertBase(string numAsString, int base1, int base2)
        {
            var isNegative = numAsString.StartsWith("-");
            var numAsInt = 0;

            for (var i = (isNegative ? 1: 0); i < numAsString.Length; i++)
            {
                numAsInt *= base1;
                numAsInt += char.IsDigit(numAsString[i])
                            ? numAsString[i] - '0'
                            : numAsString[i] - 'A' + 10;
            }

            return (isNegative ? "-" : "")
                + (numAsInt == 0 ? "0" : ConstructFromBase(numAsInt, base2));
        }

        private static string ConstructFromBase(int numAsInt, int @base)
        {
            return numAsInt == 0
                ? ""
                : ConstructFromBase(numAsInt / @base, @base)
                  + (char)(numAsInt % @base >= 10 ? 'A' + numAsInt % @base -10
                      : '0' + numAsInt % @base);
        }
    }
}