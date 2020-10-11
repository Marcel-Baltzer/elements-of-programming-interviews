using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.Alternation
{
    public class Tests
    {
        [Fact]
        public void Rearrange()
        {
            var array = new List<int>() {1,2,3,4,5,6,7,8,9};

            Solution.Rearrange(array);

            var expectedArray = new List<int>() {1,4,2,6,3,8,5,7,9};

            array.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }
    }
}