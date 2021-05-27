using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._03._Strings._07._MnemonicsForPhoneNumber
{
    public class Tests
    {
        [Fact]
        public void PhoneMnemonic()
        {
            var result = Solution.PhoneMnemonic("2276696");

            result.Should().HaveCount(3888);
            result.Should().Contain("ACRONYM");
        }
    }
}