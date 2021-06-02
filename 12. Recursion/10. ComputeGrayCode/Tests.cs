using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._10._ComputeGrayCode
{
    public class Tests
    {
        [Fact]
        public void GrayCode()
        {
            var result = Solution.GrayCode(4);

            var expectedResult = new List<int> {0, 1, 3, 2, 6, 7, 5, 4, 12, 13, 15, 14, 10, 11, 9, 8};

            result.Should().BeEquivalentTo(expectedResult, options => options.WithoutStrictOrdering());
        }

        [Fact]
        public void GrayCodeTwo()
        {
            var result = Solution.GrayCodeTwo(4);

            var expectedResult = new List<int> {0, 1, 3, 2, 6, 7, 5, 4, 12, 13, 15, 14, 10, 11, 9, 8};

            result.Should().BeEquivalentTo(expectedResult, options => options.WithoutStrictOrdering());
        }
    }
}