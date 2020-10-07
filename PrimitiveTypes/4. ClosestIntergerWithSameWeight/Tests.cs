using Xunit;
using System;
using FluentAssertions;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ClosestIntergerWithSameWeight
{
    public class Tests
    {
        [Fact]
        public static void ClosestIntWithSameBitCount_WithWrongArgument_ReturnsArgumentException()
        {

            Action act = () => Solution.ClosestIntWithSameBitCount(0);

            act.Should().Throw<ArgumentException>()
                        .WithMessage("All bits are 0 or 1");           
        }

        [Fact]
        public static void ClosestIntWithSameBitCount()
        {
            var result = Solution.ClosestIntWithSameBitCount(7);

            result.Should().Be(11);
        }
    }
}