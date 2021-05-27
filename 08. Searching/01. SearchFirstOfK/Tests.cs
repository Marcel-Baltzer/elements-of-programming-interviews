using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._08._Searching._01._SearchFirstOfK
{
    public class Tests
    {
        [Theory]
        [InlineData(108, 3)]
        [InlineData(285, 6)]
        public void SearchFirstOfK(int key, int expectedResult)
        {
            var array = new List<int> { -14, -10, 2, 108, 108, 243, 285, 285, 285, 401 };

            var result = Solution.SearchFirstOfK(array, key);

            result.Should().Be(expectedResult);
        }
    }
}