using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._01._PrimitiveTypes._11._RectangleIntersection
{
    public class Tests
    {
        [Fact]
        public void IntersectRectangle_NoIntersection()
        {
            var rectangleOne = new Solution.Rectangle(1,1,1,1);
            var rectangleTwo = new Solution.Rectangle(3,3,1,1);
            
            var result = Solution.IntersectRectangle(rectangleOne, rectangleTwo);

            result.Should().BeEquivalentTo(new Solution.Rectangle(0, 0, -1, -1)); // No intersection
        }

        [Fact]
        public void IntersectRectangle()
        {
            var rectangleOne = new Solution.Rectangle(1,1,1,1);
            var rectangleTwo = new Solution.Rectangle(2,2,1,1);
            
            var result = Solution.IntersectRectangle(rectangleOne, rectangleTwo);

            result.Should().BeEquivalentTo(new Solution.Rectangle(2, 2, 0, 0));
        }
    }
}