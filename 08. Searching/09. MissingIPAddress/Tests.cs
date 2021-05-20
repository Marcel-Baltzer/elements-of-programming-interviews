using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.MissingIPAddress
{
    public class Tests
    {
        [Fact]
        public void FindMissingElement()
        {
            var enumerable = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result = Solution.FindMissingElement(enumerable.GetEnumerator());

            result.Should().Be(7);
        }
    }
}