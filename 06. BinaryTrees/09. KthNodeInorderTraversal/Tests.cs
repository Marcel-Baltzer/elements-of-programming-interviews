using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.BinaryTrees.KthNodeInorderTraversal
{
    public class Tests
    {
        [Fact]
        public void FindKthNodeBinaryTree()
        {
            var A = new BinaryTreeNodeWithSize<int>() { Data = 314 };
            var B = new BinaryTreeNodeWithSize<int>() { Data = 6 };
            var C = new BinaryTreeNodeWithSize<int>() { Data = 271 };
            var D = new BinaryTreeNodeWithSize<int>() { Data = 28 };
            var E = new BinaryTreeNodeWithSize<int>() { Data = 0 };
            var F = new BinaryTreeNodeWithSize<int>() { Data = 561 };
            var G = new BinaryTreeNodeWithSize<int>() { Data = 3 };
            var H = new BinaryTreeNodeWithSize<int>() { Data = 17 };
            var I = new BinaryTreeNodeWithSize<int>() { Data = 6 };
            var J = new BinaryTreeNodeWithSize<int>() { Data = 2 };
            var K = new BinaryTreeNodeWithSize<int>() { Data = 1 };
            var L = new BinaryTreeNodeWithSize<int>() { Data = 401 };
            var M = new BinaryTreeNodeWithSize<int>() { Data = 641 };
            var N = new BinaryTreeNodeWithSize<int>() { Data = 257 };
            var O = new BinaryTreeNodeWithSize<int>() { Data = 271 };
            var P = new BinaryTreeNodeWithSize<int>() { Data = 28 };

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

            var result = Solution.FindKthNodeBinaryTree(A, 10);

            result.Should().BeEquivalentTo(L);
        }
    }
}