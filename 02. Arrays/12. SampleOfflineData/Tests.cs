using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._12._SampleOfflineData
{
    public class Tests
    {
        [Fact]
        public void RandomSampling()
        {
            var array = new List<int>() {3,7,5,11};

            Solution.RandomSampling(3, array);

            var arrayCopy = new List<int>() {3,7,5,11};

            array.Should().BeEquivalentTo(arrayCopy, options => options.WithoutStrictOrdering());
        }
    }
}