using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.BaseConversion
{
    public class Tests
    {
        [Fact]
        public void ConvertBase()
        {
            var result = Solution.ConvertBase("615", 7 ,13);

            result.Should().Be("1A7");
        }
    }
}