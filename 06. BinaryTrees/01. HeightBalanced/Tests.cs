using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._01._HeightBalanced
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