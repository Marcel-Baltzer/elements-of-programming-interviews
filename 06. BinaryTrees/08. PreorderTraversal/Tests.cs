using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._08._PreorderTraversal
{
    public class Tests
    {
        [Fact]
        public void PreorderTraversal()
        {
            var A = new BinaryTreeNode<int>() { Data = 314 };
            var B = new BinaryTreeNode<int>() { Data = 6 };
            var C = new BinaryTreeNode<int>() { Data = 271 };
            var D = new BinaryTreeNode<int>() { Data = 28 };
            var E = new BinaryTreeNode<int>() { Data = 0 };
            var F = new BinaryTreeNode<int>() { Data = 561 };
            var G = new BinaryTreeNode<int>() { Data = 3 };
            var H = new BinaryTreeNode<int>() { Data = 17 };
            var I = new BinaryTreeNode<int>() { Data = 6 };
            var J = new BinaryTreeNode<int>() { Data = 2 };
            var K = new BinaryTreeNode<int>() { Data = 1 };
            var L = new BinaryTreeNode<int>() { Data = 401 };
            var M = new BinaryTreeNode<int>() { Data = 641 };
            var N = new BinaryTreeNode<int>() { Data = 257 };
            var O = new BinaryTreeNode<int>() { Data = 271 };
            var P = new BinaryTreeNode<int>() { Data = 28 };

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

            var result = Solution.PreorderTraversal(A);

            var expectedResult = new List<int>() { 314, 6, 271, 28, 0, 561, 3, 17, 6, 2, 1, 401, 641, 257, 271, 28 };

            result.Should().BeEquivalentTo(expectedResult, options => options.WithStrictOrdering());
        }
    }
}