using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.HashTables.BootCamp
{
    public class Tests
    {
        [Fact]
        public void FindAnagrams()
        {
            var list = new List<string>() 
                {"debitcard", "elvis", "silent", "badcredit", "lives", "freedom", "listen", "levis", "money"};

            var result = Solution.FindAnagrams(list);

            var expectedResult = new List<List<string>>()
            {
                new List<string>() {"debitcard", "badcredit"},
                new List<string>() {"elvis", "lives", "levis"},
                new List<string>() {"silent", "listen"},
            };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void MergeContactLists()
        {
            var listOne = new List<string>() {"hello", "world"};
            var contactListOne = new Solution.ContactList(listOne);
            
            var listTwo = new List<string>() {"world", "hello"};
            var contactListTwo = new Solution.ContactList(listTwo);

            var result = 
                Solution.MergeContactLists(new List<Solution.ContactList>() {contactListOne, contactListTwo});

            result.Count.Should().Be(1);
        }
    }
}