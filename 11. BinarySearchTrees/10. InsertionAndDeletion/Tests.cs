using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._10._InsertionAndDeletion
{
    public class Tests
    {
        [Fact]
        public void BinarySearchTree_Delete_MissingKey_ReturnsFalse()
        {
            var tree = new Solution.BinarySearchTree();

            tree.Delete(5).Should().BeFalse();
        }
        
        [Fact]
        public void BinarySearchTree_InsertKey_ReturnsTrue()
        {
            var tree = new Solution.BinarySearchTree();

            tree.Insert(5).Should().BeTrue();
            tree.Insert(3).Should().BeTrue();
            tree.Insert(4).Should().BeTrue();
        }
        
        [Fact]
        public void BinarySearchTree_InsertDuplicateKey_ReturnsFalse()
        {
            var tree = new Solution.BinarySearchTree();

            tree.Insert(5).Should().BeTrue();
            tree.Insert(5).Should().BeFalse();
        }
        
        [Fact]
        public void BinarySearchTree_DeleteRootKey_ReturnsTrue()
        {
            var tree = new Solution.BinarySearchTree();

            tree.Insert(5);
            tree.Delete(5).Should().BeTrue();
        }
        
        [Fact]
        public void BinarySearchTree_DeleteKey_ReturnsTrue()
        {
            var tree = new Solution.BinarySearchTree();

            tree.Insert(5);
            tree.Insert(8);
            tree.Insert(6);
            tree.Insert(4);
            tree.Delete(6).Should().BeTrue();
        }
    }
}