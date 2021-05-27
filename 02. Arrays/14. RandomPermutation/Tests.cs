using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._14._RandomPermutation
{
    public class Tests
    {
        [Fact]
        public void ComputeRandomPermutation()
        {
            var array = new List<int>() {0,1,2,3,4,5};

            var result = Solution.ComputeRandomPermutation(array.Count);

            result.Should().BeEquivalentTo(array, options => options.WithoutStrictOrdering());
        }
    }
}