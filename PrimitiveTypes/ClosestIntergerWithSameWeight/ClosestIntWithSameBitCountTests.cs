using Xunit;
using System;
using FluentAssertions;

namespace Elements_of_Programming_Interviews.PrimitiveTypes.ClosestIntergerWithSameWeight
{
    public class ClosestIntWithSameBitCountTests
    {
        [Fact]
        public void For_WithWrongArgument_ReturnsArgumentException()
        {
            var close = new ClosestIntWithSameBitCount();

            Action act = () => close.For(0);

            act.Should().Throw<ArgumentException>()
                        .WithMessage("All bits are 0 or 1");           
        }

        [Fact]
        public void For()
        {
            var close = new ClosestIntWithSameBitCount();

            var result = close.For(7);

            result.Should().Be(11);
        }
    }
}