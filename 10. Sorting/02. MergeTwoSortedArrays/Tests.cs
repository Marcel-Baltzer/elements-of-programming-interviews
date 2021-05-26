using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._02._MergeTwoSortedArrays
{
    public class Tests
    {
        [Fact]
        public void MergeTwoSortedArrays()
        {
            var a = new List<int>() {5, 13, 17, 0, 0, 0, 0};
            var b = new List<int>() {3, 7, 11, 19};

            Solution.MergeTwoSortedArrays(a, 3, b, 4);

            var expectedResult = new List<int>() {3, 5, 7, 11, 13, 17, 19};

            a.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}