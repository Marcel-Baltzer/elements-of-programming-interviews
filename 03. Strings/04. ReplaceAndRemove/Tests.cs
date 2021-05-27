using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._04._ReplaceAndRemove
{
    public class Tests
    {
        [Fact]
        public void ReplaceAndRemove()
        {
            var array = new char[] {'a','b','a','c',' '};

            var result = Solution.ReplaceAndRemove(4, array);

            var expectedArray = new char[] {'d','d','d','d','c'};

            result.Should().Be(5);
            array.Should().BeEquivalentTo(expectedArray, options => options.WithoutStrictOrdering());
        }
    }
}