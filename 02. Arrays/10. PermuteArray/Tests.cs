using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.PermuteArray
{
    public class Tests
    {
        [Fact]
        public void ApplyPermutation()
        {
            var permutation = new List<int>() {3,2,1,0};
            var array = new List<int>() {1,2,3,4};

            Solution.ApplyPermutation(permutation, array);

            var expectedPermutation = new List<int>() {3,2,1,0};
            var expectedArray = new List<int>() {4,3,2,1};

            array.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
            permutation.Should().BeEquivalentTo(expectedPermutation, options => options.WithStrictOrdering());
        }

        [Fact]
        public void ApplyPermutationCyclic()
        {
            var permutation = new List<int>() {3,2,1,0};
            var array = new List<int>() {1,2,3,4};

            Solution.ApplyPermutationCyclic(permutation, array);

            var expectedArray = new List<int>() {4,3,2,1};

            array.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }
    }
}