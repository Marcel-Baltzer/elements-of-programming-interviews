using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._07._EnumerateNumbers
{
    public class Tests
    {
        [Fact]
        public void GenerateFirstKsAPlusBSqrt()
        {
            var result = Solution.GenerateFirstKsAPlusBSqrt(10);

            var expectedResult = new List<Solution.APlusBSqrt2>
            {
                new(0, 0),
                new(1, 0),
                new(0, 1),
                new(2, 0),
                new(1, 1),
                new(0, 2),
                new(3, 0),
                new(2, 1),
                new(1, 2),
                new(4, 0)
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}