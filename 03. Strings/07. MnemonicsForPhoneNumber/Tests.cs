using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.MnemonicsForPhoneNumber
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