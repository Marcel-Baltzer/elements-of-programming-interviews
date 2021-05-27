using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._02._AnonymousLetter
{
    public class Tests
    {
        [Fact]
        public void IsLetterConstructibleFromMagazine()
        {
            const string letterText = "Hello World";
            const string magazineText = "Hi, We are happy to celebrate our old lol magazine.";
            
            var result =  Solution.IsLetterConstructibleFromMagazine(letterText, magazineText);

            result.Should().BeTrue();
        }
    }
}