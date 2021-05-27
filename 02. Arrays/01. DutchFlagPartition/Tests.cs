using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._02._Arrays._01._DutchFlagPartition
{
    public class Tests
    {
        List<Color> colours;
        List<Color> expectedColours;

        public Tests()
        {
            colours = new List<Color>() 
            {
                Color.BLUE,
                Color.RED, 
                Color.WHITE,
                Color.WHITE,
                Color.RED, 
                Color.BLUE,
                Color.RED,
                Color.WHITE,
                Color.BLUE
            };

            expectedColours = new List<Color>() 
            {
                Color.RED,
                Color.RED, 
                Color.RED,
                Color.WHITE,
                Color.WHITE, 
                Color.WHITE,
                Color.BLUE,
                Color.BLUE,
                Color.BLUE,
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