using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.BinaryTrees.HeightBalanced
{
    public class Tests
    {
        [Fact]
        public void IsBalanced()
        {
            var A = new BinaryTreeNode<int> { Data = 1 };
            var B = new BinaryTreeNode<int> { Data = 2 };
            var C = new BinaryTreeNode<int> { Data = 3 };
            var D = new BinaryTreeNode<int> { Data = 4 };
            var E = new BinaryTreeNode<int> { Data = 5 };

            A.Left = B;
            A.Right = C;
            B.Left = D;
            B.Right = E;

            var result = Solution.IsBalanced(A);

            result.Should().BeTrue();
        }
    }
}