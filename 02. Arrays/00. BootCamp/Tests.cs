using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._00._BootCamp
{
    public class Tests
    {
        [Fact]
        public void EvenOdd()
        {
            var array = new int[] {1, 2, 5, 6, 8, 4, 1};
            var expectedArray = new int[] {4, 2, 8, 6, 5, 1, 1};

            Solution.EvenOdd(array);

            array.Should().BeEquivalentTo(expectedArray, options => options.WithStrictOrdering());
        }
    }
}