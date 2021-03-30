using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.BinaryTrees.Symmetric
{
    public class Tests
    {
        [Fact]
        public void IsSymmetric()
        {
            var A = new BinaryTreeNode<int> { Data = 314 };
            var B = new BinaryTreeNode<int> { Data = 6 };
            var C = new BinaryTreeNode<int> { Data = 2 };
            var D = new BinaryTreeNode<int> { Data = 3 };
            var E = new BinaryTreeNode<int> { Data = 6 };
            var F = new BinaryTreeNode<int> { Data = 2 };
            var G = new BinaryTreeNode<int> { Data = 3 };

            A.Left = B;
            B.Right = C;
            C.Right = D;

            A.Right = E;
            E.Left = F;
            F.Left = G;

            var result = Solution.IsSymmetric(A);

            result.Should().BeTrue();
        }
    }
}