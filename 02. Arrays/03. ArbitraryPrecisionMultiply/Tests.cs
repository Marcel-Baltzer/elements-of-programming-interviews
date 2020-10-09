using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.ArbitraryPrecisionMultiply
{
    public class Tests
    {
        [Fact]
        public void MultiplyWithZero()
        {
            	var numberOne = new List<int> {1,5};
                var numberTwo = new List<int> {0};

                var result = Solution.Multiply(numberOne, numberTwo);

                result.Should().BeEquivalentTo(new List<int> {0});
        }

        [Fact]
        public void MultiplyWithNegativNumber()
        {
            	var numberOne = new List<int> {1,5};
                var numberTwo = new List<int> {-1};

                var result = Solution.Multiply(numberOne, numberTwo);

                result.Should().BeEquivalentTo(new List<int> {-1,5}, option => option.WithStrictOrdering());
        }

        [Fact]
        public void Multiply()
        {
            	var numberOne = new List<int> {1,5,6,7};
                var numberTwo = new List<int> {5,4,9,3};

                var result = Solution.Multiply(numberOne, numberTwo);

                result.Should().BeEquivalentTo(new List<int> {8, 6, 0, 7, 5, 3, 1}, option => option.WithStrictOrdering());
        }
    }
}