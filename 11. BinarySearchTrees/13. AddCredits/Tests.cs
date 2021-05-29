using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._13._AddCredits
{
    public class Tests
    {
        [Fact]
        public void AddCredits_EmptyLookup_ReturnsMinusOne()
        {
            var credit = new Solution.ClientsCreditsInfo();

            credit.Lookup("A").Should().Be(-1);
        }
        
        [Fact]
        public void AddCredits_Lookup_ReturnsValue()
        {
            var credit = new Solution.ClientsCreditsInfo();
            
            credit.Insert("A", 4);

            credit.Lookup("A").Should().Be(4);
        }
        
        [Fact]
        public void AddCredits_Max_ReturnsMaxValue()
        {
            var credit = new Solution.ClientsCreditsInfo();
            
            credit.Insert("A", 4);
            credit.Insert("B", 8);
            credit.Insert("C", 5);

            credit.Max().Should().Be("B");
        }
        
        [Fact]
        public void AddCredits_AddAllAfterInsert_ReturnsValuePlusOffset()
        {
            var credit = new Solution.ClientsCreditsInfo();
            
            credit.Insert("A", 4);
            credit.AddAll(2);

            credit.Lookup("A").Should().Be(6);
        }
        
        [Fact]
        public void AddCredits_AddAllBeforeInsert_ReturnsValue()
        {
            var credit = new Solution.ClientsCreditsInfo();
            
            credit.AddAll(2);
            credit.Insert("A", 4);

            credit.Lookup("A").Should().Be(4);
        }
        
        [Fact]
        public void AddCredits_InsertWithSameValue_MaxReturnsFirstValue()
        {
            var credit = new Solution.ClientsCreditsInfo();
            
            credit.Insert("B", 4);
            credit.Insert("C", 4);
            credit.Insert("A", 4);
            credit.Insert("D", 4);

            credit.Max().Should().Be("B");
        }
        
        [Fact]
        public void AddCredits_EmptyRemove_ReturnsFalse()
        {
            var credit = new Solution.ClientsCreditsInfo();

            credit.Remove("A").Should().BeFalse();
        }
        
        [Fact]
        public void AddCredits_Remove_ReturnsTrue()
        {
            var credit = new Solution.ClientsCreditsInfo();

            credit.Insert("A", 4);
            credit.Remove("A").Should().BeTrue();
            credit.Lookup("A").Should().Be(-1);
        }
    }
}