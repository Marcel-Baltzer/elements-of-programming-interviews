using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._00._BootCamp
{
    public class Tests
    {
        [Fact]
        public void TreeTraversal()
        {
            var A = new BinaryTreeNode<int> { Data = 1 };
            var B = new BinaryTreeNode<int> { Data = 2 };
            var C = new BinaryTreeNode<int> { Data = 3 };
            var D = new BinaryTreeNode<int> { Data = 4 };
            var E = new BinaryTreeNode<int> { Data = 5 };

            A.Left = B;
            B.Left = C;
            B.Right = D;
            A.Right = E;

            Solution.TreeTraversal(A);
        }
    }
}