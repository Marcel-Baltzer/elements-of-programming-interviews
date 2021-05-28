using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._02._FindGreaterKey
{
    public class Tests
    {
        [Fact]
        public void IsBinaryTreeBinarySearchTree()
        {
            var A = new BinarySearchTreeNode<int> { Data = 19 };
            var B = new BinarySearchTreeNode<int> { Data = 7 };
            var C = new BinarySearchTreeNode<int> { Data = 3 };
            var D = new BinarySearchTreeNode<int> { Data = 2 };
            var E = new BinarySearchTreeNode<int> { Data = 5 };
            var F = new BinarySearchTreeNode<int> { Data = 11 };
            var G = new BinarySearchTreeNode<int> { Data = 17 };
            var H = new BinarySearchTreeNode<int> { Data = 13 };
            var I = new BinarySearchTreeNode<int> { Data = 43 };
            var J = new BinarySearchTreeNode<int> { Data = 23 };
            var K = new BinarySearchTreeNode<int> { Data = 37 };
            var L = new BinarySearchTreeNode<int> { Data = 29 };
            var M = new BinarySearchTreeNode<int> { Data = 31 };
            var N = new BinarySearchTreeNode<int> { Data = 41 };
            var O = new BinarySearchTreeNode<int> { Data = 47 };
            var P = new BinarySearchTreeNode<int> { Data = 53 };

            A.Left = B;
            B.Left = C;
            C.Left = D;
            C.Right = E;
            B.Right = F;
            F.Right = G;
            G.Left = H;

            A.Right = I;
            I.Left = J;
            J.Right = K;
            K.Left = L;
            L.Right = M;
            K.Right = N;
            I.Right = O;
            O.Right = P;

            var result = Solution.FindFirstGreaterThanK(A, 23);

            result.Data.Should().Be(29);
        }
    }
}