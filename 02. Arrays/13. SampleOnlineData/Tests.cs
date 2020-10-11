using System.Collections.Generic;
using FluentAssertions;
using FakeItEasy;
using Xunit;

namespace Elements_of_Programming_Interviews.Arrays.SampleOnlineData
{
    public class Tests
    {
        [Fact]
        public void OnlineRandomSample()
        {         
            var enumerable  = new List<int>() {3,5,1,2,4,6};           

            var result = Solution.OnlineRandomSample(enumerable.GetEnumerator(), 2);

            result.Count.Should().Be(2);
        }
    }
}