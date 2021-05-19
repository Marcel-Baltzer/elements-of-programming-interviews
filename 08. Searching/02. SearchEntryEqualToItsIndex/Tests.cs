using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.Searching.SearchEntryEqualToItsIndex
{
    public class Tests
    {
        [Fact]
        public void SearchEntryEqualToItsIndex()
        {
            var array = new List<int> { -2, 0, 2, 3, 6, 7, 9 };

            var result = Solution.SearchEntryEqualToItsIndex(array);

            result.Should().Be(3);
        }

        [Fact]
        public void SearchEntryEqualToItsIndex_WithNoMatch()
        {
            var array = new List<int> { -2, 0, 4, 2, 6, 7, 9 };

            var result = Solution.SearchEntryEqualToItsIndex(array);

            result.Should().Be(-1);
        }
    }
}