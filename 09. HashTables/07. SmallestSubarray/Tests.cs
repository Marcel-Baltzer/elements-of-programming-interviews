using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._07._SmallestSubarray
{
    public class Tests
    {
        [Fact]
        public void FindSmallestSubarrayCoveringSet()
        {
            var paragraph = new List<string>()
                {"apple", "banana", "apple", "apple", "dog", "cat", "apple", "dog", "banana", "apple", "cat", "dog"};

            var keywords = new HashSet<string>() {"banana", "cat"};

            var result = Solution.FindSmallestSubarrayCoveringSet(paragraph, keywords);

            result.Start.Should().Be(8);
            result.End.Should().Be(10);
        }
        
        [Fact]
        public void FindSmallestSubarrayCoveringSubset()
        {
            var paragraph = new List<string>()
                {"apple", "banana", "apple", "apple", "dog", "cat", "apple", "dog", "banana", "apple", "cat", "dog"};

            var keywords = new List<string>() {"banana", "cat"};

            var result = Solution.FindSmallestSubarrayCoveringSubset(paragraph.GetEnumerator(), keywords);

            result.Start.Should().Be(8);
            result.End.Should().Be(10);
        }
    }
}