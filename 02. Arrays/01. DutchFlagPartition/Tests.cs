using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._01._DutchFlagPartition
{
    public class Tests
    {
        private readonly List<Color> colours;
        private readonly List<Color> expectedColours;

        public Tests()
        {
            colours = new List<Color>() 
            {
                Color.Blue,
                Color.Red, 
                Color.White,
                Color.White,
                Color.Red, 
                Color.Blue,
                Color.Red,
                Color.White,
                Color.Blue
            };

            expectedColours = new List<Color>() 
            {
                Color.Red,
                Color.Red, 
                Color.Red,
                Color.White,
                Color.White, 
                Color.White,
                Color.Blue,
                Color.Blue,
                Color.Blue,
            };
        }

        [Fact]
        public void DutchFlagPartitionVariationOne()
        {     
            Solution.DutchFlagPartitionVariationOne(3, colours);

            colours.Should().BeEquivalentTo(expectedColours, options => options.WithStrictOrdering());
        }

        [Fact]
        public void DutchFlagPartitionVariationTwo()
        {     
            Solution.DutchFlagPartitionVariationTwo(3, colours);

            colours.Should().BeEquivalentTo(expectedColours, options => options.WithStrictOrdering());
        }

                [Fact]
        public void DutchFlagPartitionVariationThree()
        {     
            Solution.DutchFlagPartitionVariationThree(3, colours);

            colours.Should().BeEquivalentTo(expectedColours, options => options.WithStrictOrdering());
        }
    }
}