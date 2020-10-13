using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.PascalTriangle
{
    public class Tests
    {
        [Fact]
        public void GeneratePascalTriangle()
        {
            var result = Solution.GeneratePascalTriangle(5);

             var expectedResult = new List<List<int>>
             {
                 new List<int> {1},
                 new List<int> {1,1},
                 new List<int> {1,2,1},
                 new List<int> {1,3,3,1},
                 new List<int> {1,4,6,4,1}
             };

             result.Should().BeEquivalentTo(expectedResult, options => options.WithoutStrictOrdering());
        }
    }
}