using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._17._Locking
{
    public class Tests
    {
        [Fact]
        public void BinaryTree()
        {
            var A = new Solution.BinaryTree();
            var B = new Solution.BinaryTree();
            var C = new Solution.BinaryTree();
            var D = new Solution.BinaryTree();
            var E = new Solution.BinaryTree();
            var F = new Solution.BinaryTree();
            var G = new Solution.BinaryTree();

            A.Left = B;
            B.Parent = A;
            B.Right = C;
            C.Parent = B;
            C.Right = D;
            D.Parent = C;

            A.Right = E;
            E.Parent = A;
            E.Left = F;
            F.Parent = E;
            F.Left = G;
            G.Parent = F;

            var result = B.Lock();
            result.Should().BeTrue();
            B.IsLocked().Should().BeTrue();
            result = B.Lock();
            result.Should().BeFalse();

            result = C.Lock();
            result.Should().BeFalse();
            C.IsLocked().Should().BeFalse();

            result = A.Lock();
            result.Should().BeFalse();
            A.IsLocked().Should().BeFalse();

            B.Unlock();
            B.IsLocked().Should().BeFalse();
        }
    }
}