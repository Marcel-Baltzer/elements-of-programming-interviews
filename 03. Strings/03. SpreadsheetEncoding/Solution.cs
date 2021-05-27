namespace Elements_of_Programming_Interviews._03._Strings._03._SpreadsheetEncoding
{
    public class Solution
    {
        public static int SpreadsheetDecodeColumnId(string column)
        {
            var result = 0;

            for (var i = 0; i < column.Length; i++)
            {
                var c = column[i];
                result = result * 26 + c - 'A' +1;
            }

            return result;
        }
    }
}