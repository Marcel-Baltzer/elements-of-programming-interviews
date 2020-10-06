using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.Division
{
    public class DivisionTests
    {
        [Fact]
        public void For(){
            
            var divide = new Division();

            var result = divide.For(137, 7);

            result.Should().Be(19);
        }
    }
}