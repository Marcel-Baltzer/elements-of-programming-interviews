using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.FrequentQueries
{
    public class Tests
    {
        [Fact]
        public void ComputeFrequentStrings()
        {
            var list = new List<string>() { "hello", "!", "world", "world", "hello", "here", "return", "hello", "", "world", "hello", "list", "!", "hash",};

            var result = Solution.ComputeFrequentStrings(list, 3);

            var expectedResult = new List<string>() {"hello", "world", "!"};
            
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}