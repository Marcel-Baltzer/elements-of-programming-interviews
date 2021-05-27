using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._05._DeleteDuplicates
{
    public class Tests
    {
        [Theory]
        [MemberData(nameof(Data))]
        public void DeleteDuplicates(List<int> sortedArray, int expectedResult)
        {
            var result = Solution.DeleteDuplicates(sortedArray);

            result.Should().Be(expectedResult);
        }

        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[] {new List<int>(), 0},
                new object[] {new List<int> {2,3,5,5,7,11,11,11,13}, 6},
                new object[] {new List<int> {1,1,1,1,1,1,1,1,1,1,1}, 1}
            };
    }
}