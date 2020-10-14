namespace Elements_of_Programming_Interviews.Strings.SpreadsheetEncoding
{
    public class Solution
    {
        public static int SpreadsheetDecodeColumnId(string column)
        {
            int result = 0;

            for (int i = 0; i < column.Length; i++)
            {
                char c = column[i];
                result = result * 26 + c - 'A' +1;
            }

            return result;
        }
    }
}