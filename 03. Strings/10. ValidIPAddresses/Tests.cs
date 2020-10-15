using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Strings.ValidIPAddresses
{
    public class Tests
    {
        [Fact]
        public void GetValidIpAddress()
        {
            var result = Solution.GetValidIpAddress("19216811");

            var expectedResult = new List<string>
            {
                "1.92.168.11",
                "19.2.168.11",
                "19.21.68.11",
                "19.216.8.11",
                "19.216.81.1",
                "192.1.68.11",
                "192.16.8.11",
                "192.16.81.1",
                "192.168.1.1"
            };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithoutStrictOrdering());
        }
    }
}