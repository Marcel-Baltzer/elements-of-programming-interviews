using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._03._SpreadsheetEncoding
{
    public class Tests
    {
        [Theory]
        [InlineData("A", 1)]
        [InlineData("B", 2)]
        [InlineData("AA", 27)]
        [InlineData("ZZ", 702)]
        public void SpreadsheetDecodeColumnId(string column, int expectedResult)
        {
            var result = Solution.SpreadsheetDecodeColumnId(column);

            result.Should().Be(expectedResult);
        }
    }
}