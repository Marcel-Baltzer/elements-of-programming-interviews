using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.FindKthLargestElement
{
    public class Tests
    {
        [Theory]
        [InlineData(1, 3)]
        [InlineData(2, 2)]
        [InlineData(3, 1)]
        [InlineData(4, -1)]
        [InlineData(5, int.MinValue)]
        public void FindKthLargest(int k, int expectedResult)
        {
            var array = new List<int>() { 3, 1, -1, 2 };

            var result = Solution.FindKthLargest(array, k);

            result.Should().Be(expectedResult);
        }
    }
}