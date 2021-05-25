using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._01._IntersectionTwoSortedArrays
{
    public class Tests
    {
        [Fact]
        public void IntersectTwoSortedArraysWithEquals()
        {
            var a = new List<int>() {2, 3, 3, 5, 5, 6, 7, 7, 8, 12};
            var b = new List<int>() {5, 5, 6, 8, 8, 9, 10, 10};

            var result = Solution.IntersectTwoSortedArraysWithEquals(a, b);

            var expectedResult = new List<int>() {5, 6, 8};

            result.Should().BeEquivalentTo(expectedResult);
        }
        
        [Fact]
        public void IntersectTwoSortedArraysWithBinarySearch()
        {
            var a = new List<int>() {2, 3, 3, 5, 5, 6, 7, 7, 8, 12};
            var b = new List<int>() {5, 5, 6, 8, 8, 9, 10, 10};

            var result = Solution.IntersectTwoSortedArraysWithBinarySearch(a, b);

            var expectedResult = new List<int>() {5, 6, 8};

            result.Should().BeEquivalentTo(expectedResult);
        }
        
        [Fact]
        public void IntersectTwoSortedArrays()
        {
            var a = new List<int>() {2, 3, 3, 5, 5, 6, 7, 7, 8, 12};
            var b = new List<int>() {5, 5, 6, 8, 8, 9, 10, 10};

            var result = Solution.IntersectTwoSortedArrays(a, b);

            var expectedResult = new List<int>() {5, 6, 8};

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}