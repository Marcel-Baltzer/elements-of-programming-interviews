using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._11._ComputeNextPermutation
{
    public class Tests
    {
        [Fact]
        public void NextPermutation()
        {
            var permutation = new List<int>() {6,2,1,5,4,3,0};

            var result = Solution.NextPermutation(permutation);

            var expectedPermutation = new List<int>() {6,2,3,0,1,4,5};

            result.Should().BeEquivalentTo(expectedPermutation, options => options.WithStrictOrdering());
        }
    }
}