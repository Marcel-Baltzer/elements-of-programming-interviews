using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.GeneratePrimes
{
    public class Tests
    {
        [Fact]
        public void GeneratePrimes()
        {
            var result = Solution.GeneratePrimes(18);

            var expectedPrimes = new List<int>() {2,3,5,7,11,13,17};

            result.Should().BeEquivalentTo(expectedPrimes, options => options.WithStrictOrdering());
        }

        [Fact]
        public void GeneratePrimesOptimization()
        {
            var result = Solution.GeneratePrimesOptimization(18);

            var expectedPrimes = new List<int>() {2,3,5,7,11,13,17};

            result.Should().BeEquivalentTo(expectedPrimes, options => options.WithStrictOrdering());
        }
    }
}