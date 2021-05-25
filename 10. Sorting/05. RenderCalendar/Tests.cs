using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._10._Sorting._05._RenderCalendar
{
    public class Tests
    {
        [Fact]
        public void FindMaxSimultaneousEvents()
        {
            var list = new List<Solution.Event>()
            {
                new Solution.Event(1,5),
                new Solution.Event(6,10),
                new Solution.Event(11,13),
                new Solution.Event(14,15),
                new Solution.Event(2,7),
                new Solution.Event(8,9),
                new Solution.Event(12,15),
                new Solution.Event(4,5),
                new Solution.Event(9,17)
            };
            
            var result = Solution.FindMaxSimultaneousEvents(list);


            result.Should().Be(3);
        }
    }
}