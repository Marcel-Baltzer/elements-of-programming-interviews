using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._04._NonConstructibleValue
{
    public class Tests
    {
        [Fact]
        public void SmallestNonConstructibleValue()
        {
            var list = new List<int> {12, 2, 1, 15, 2, 4};

            var result = Solution.SmallestNonConstructibleValue(list);

            result.Should().Be(10);
        }
    }
}