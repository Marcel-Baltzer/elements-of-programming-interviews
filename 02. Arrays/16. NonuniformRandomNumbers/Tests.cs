using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._16._NonuniformRandomNumbers
{
    public class Tests
    {
        [Fact]
        public void NonuniformRandomNumberGeneration()
        {
            var values = new List<int>() {3, 5, 7, 11};
            var probabilities = new List<double>() {9.0/18, 6.0/18, 2.0/18, 1.0/18};

            var result = Solution.NonuniformRandomNumberGeneration(values, probabilities);

            values.Should().Contain(result); 
        }
    }
}