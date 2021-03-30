using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews.StacksAndQueues.ComputeBinaryTree
{
    public class Tests
    {
        [Fact]
        public void BinaryTreeDepthOrder()
        {
            var A = new Solution.BinaryTreeNode<int>() { Data = 314 };
            var B = new Solution.BinaryTreeNode<int>() { Data = 6 };
            var C = new Solution.BinaryTreeNode<int>() { Data = 271 };
            var D = new Solution.BinaryTreeNode<int>() { Data = 28 };
            var E = new Solution.BinaryTreeNode<int>() { Data = 0 };
            var F = new Solution.BinaryTreeNode<int>() { Data = 561 };
            var G = new Solution.BinaryTreeNode<int>() { Data = 3 };
            var H = new Solution.BinaryTreeNode<int>() { Data = 17 };
            var I = new Solution.BinaryTreeNode<int>() { Data = 6 };
            var J = new Solution.BinaryTreeNode<int>() { Data = 2 };
            var K = new Solution.BinaryTreeNode<int>() { Data = 1 };
            var L = new Solution.BinaryTreeNode<int>() { Data = 401 };
            var M = new Solution.BinaryTreeNode<int>() { Data = 641 };
            var N = new Solution.BinaryTreeNode<int>() { Data = 257 };
            var O = new Solution.BinaryTreeNode<int>() { Data = 271 };
            var P = new Solution.BinaryTreeNode<int>() { Data = 28 };

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

            var result = Solution.BinaryTreeDepthOrder(A);

            var expectedResult = new List<List<int>>()
            {
                new List<int>() {314},
                new List<int>() {6,6},
                new List<int>() {271,561,2,271},
                new List<int>() {28,0,3,1,28},
                new List<int>() {17,401,257},
                new List<int>() {641},
            };

            result.Should().BeEquivalentTo(expectedResult);

        }
    }
}