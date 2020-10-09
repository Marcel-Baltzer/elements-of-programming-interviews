using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.AdvanceThrough
{
    public class Tests
    {
        [Fact]
        public void CanReachEnd_ReturnsTrue()
        {
            var steps = new List<int>() {3,3,1,0,2,0,1};

            var restult = Solution.CanReachEnd(steps);

            restult.Should().BeTrue();
        }

        [Fact]
        public void CanReachEnd_ReturnsFalse()
        {
            var steps = new List<int>() {3,2,0,0,2,0,1};

            var restult = Solution.CanReachEnd(steps);

            restult.Should().BeFalse();
        }
    }
}