using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._09._HashTables._03._ISBNCache
{
    public class Tests
    {
        private readonly Solution.LRUCache cache;

        public Tests()
        {
            cache = new Solution.LRUCache(3);
        }

        [Fact]
        public void LRUCache_LookupMissingKey()
        {
            cache.Lookup(1).Should().Be(-1);
        }

        [Fact]
        public void LRUCache_InsertAndLookupKey()
        {
            cache.Insert(1, 1).Should().Be(1);
            cache.Lookup(1).Should().Be(1);
        }
        
        [Fact]
        public void LRUCache_InsertKeyTwice()
        {
            cache.Insert(1, 1);
            cache.Insert(1, 2).Should().Be(-1);
            cache.Lookup(1).Should().Be(1);
        }
        
        [Fact]
        public void LRUCache_ReachCapacity()
        {
            cache.Insert(1, 1);
            cache.Insert(2, 2);
            cache.Insert(3, 3);
            cache.Insert(4, 4);

            cache.Lookup(1).Should().Be(-1);
        }
        
        [Fact]
        public void LRUCache_EraseMissingKey()
        {
            cache.Erase(1).Should().Be(-1);
        }
        
        [Fact]
        public void LRUCache_EraseKey()
        {
            cache.Insert(1, 1);
            cache.Erase(1).Should().Be(1);
            cache.Lookup(1).Should().Be(-1);
        }
    }
}