using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._02._ArbitraryPrecisionIncrement
{
    public class Tests
    {
        [Fact]
        public void PlusOne()
        {
            var number = new List<int>() {9,9};

            var result = Solution.PlusOne(number);

            var expectedResult = new List<int>() {1,0,0};

            result.Should().BeEquivalentTo(expectedResult, option => option.WithStrictOrdering());
        }
    }
}