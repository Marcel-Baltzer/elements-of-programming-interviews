using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._05._SumRootToLeafPath
{
    public class Tests
    {
        [Fact]
        public void SumRootToLeaf()
        {
            var A = new BinaryTreeNode<int>() { Data = 1 };
            var B = new BinaryTreeNode<int>() { Data = 0 };
            var C = new BinaryTreeNode<int>() { Data = 0 };
            var D = new BinaryTreeNode<int>() { Data = 0 };
            var E = new BinaryTreeNode<int>() { Data = 1 };
            var F = new BinaryTreeNode<int>() { Data = 1 };
            var G = new BinaryTreeNode<int>() { Data = 1 };
            var H = new BinaryTreeNode<int>() { Data = 0 };
            var I = new BinaryTreeNode<int>() { Data = 1 };
            var J = new BinaryTreeNode<int>() { Data = 0 };
            var K = new BinaryTreeNode<int>() { Data = 0 };
            var L = new BinaryTreeNode<int>() { Data = 1 };
            var M = new BinaryTreeNode<int>() { Data = 1 };
            var N = new BinaryTreeNode<int>() { Data = 0 };
            var O = new BinaryTreeNode<int>() { Data = 0 };
            var P = new BinaryTreeNode<int>() { Data = 0 };

            A.Left = B;
            A.Right = I;
            B.Left = C;
            B.Right = F;
            C.Left = D;
            C.Right = E;
            F.Right = G;
            G.Left = H;
            I.Left = J;
            I.Right = O;
            J.Right = K;
            K.Left = L;
            K.Right = N;
            L.Right = M;
            O.Right = P;

            var result = Solution.SumRootToLeaf(A);

            result.Should().Be(126);
        }
    }
}