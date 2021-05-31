using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._02._NonAttackingPlacementsOfQueens
{
    public class Tests
    {
        [Fact]
        public void NQueens()
        {
            var result = Solution.NQueens(4);

            var expectedResult = new List<List<int>>
            {
                new () {1,3,0,2},
                new () {2,0,3,1}
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}