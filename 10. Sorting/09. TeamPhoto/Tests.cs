using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._09._TeamPhoto
{
    public class Tests
    {
        [Fact]
        public void ValidPlacementExists()
        {
            var teamAHeights = new List<int>() {1, 5, 8, 2, 9, 4, 3, 7, 6, 8};
            var teamBHeights = new List<int>() {10, 8, 4, 5, 7, 3, 9, 2, 6};

            var teamA = new Solution.Team(teamAHeights);
            var teamB = new Solution.Team(teamBHeights);

            var result = Solution.ValidPlacementExists(teamA, teamB);

            result.Should().BeTrue();
        }
    }
}