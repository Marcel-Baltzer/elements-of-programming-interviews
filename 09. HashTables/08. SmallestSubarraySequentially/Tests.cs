using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.SmallestSubarraySequentially
{
    public class Tests
    {
        [Fact]
        public void FindSmallestSequentiallyCoveringSubset()
        {
            var paragraph = new List<string>() {"apple", "banana", "cat", "apple"};
            var keywords = new List<string>() {"banana", "apple"};

            var result = Solution.FindSmallestSequentiallyCoveringSubset(paragraph, keywords);

            result.Start.Should().Be(1);
            result.End.Should().Be(3);
        }
    }
}