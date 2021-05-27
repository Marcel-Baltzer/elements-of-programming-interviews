using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._08._Searching._10._DuplicateAndMissing
{
    public class Tests
    {
        [Fact]
        public void FindDuplicateMissing()
        {
            var array = new List<int>() { 5, 3, 0, 3, 1, 2 };

            var result = Solution.FindDuplicateMissing(array);

            result.Duplicate.Should().Be(3);
            result.Missing.Should().Be(4);
        }
    }
}