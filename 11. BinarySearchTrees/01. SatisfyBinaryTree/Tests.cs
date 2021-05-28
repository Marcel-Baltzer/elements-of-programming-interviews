using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._01._SatisfyBinaryTree
{
    public class Tests
    {
        [Fact]
        public void IsBinaryTreeBinarySearchTree()
        {
            var A = new BinaryTreeNode<int> { Data = 19 };
            var B = new BinaryTreeNode<int> { Data = 7 };
            var C = new BinaryTreeNode<int> { Data = 3 };
            var D = new BinaryTreeNode<int> { Data = 2 };
            var E = new BinaryTreeNode<int> { Data = 5 };
            var F = new BinaryTreeNode<int> { Data = 11 };
            var G = new BinaryTreeNode<int> { Data = 17 };
            var H = new BinaryTreeNode<int> { Data = 13 };
            var I = new BinaryTreeNode<int> { Data = 43 };
            var J = new BinaryTreeNode<int> { Data = 23 };
            var K = new BinaryTreeNode<int> { Data = 37 };
            var L = new BinaryTreeNode<int> { Data = 29 };
            var M = new BinaryTreeNode<int> { Data = 31 };
            var N = new BinaryTreeNode<int> { Data = 41 };
            var O = new BinaryTreeNode<int> { Data = 47 };
            var P = new BinaryTreeNode<int> { Data = 53 };

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

            var result = Solution.IsBinaryTreeBinarySearchTree(A);

            result.Should().BeTrue();
        }
        
        [Fact]
        public void IsBinaryTreeBinarySearchTreeWithQueue()
        {
            var A = new BinaryTreeNode<int> { Data = 19 };
            var B = new BinaryTreeNode<int> { Data = 7 };
            var C = new BinaryTreeNode<int> { Data = 3 };
            var D = new BinaryTreeNode<int> { Data = 2 };
            var E = new BinaryTreeNode<int> { Data = 5 };
            var F = new BinaryTreeNode<int> { Data = 11 };
            var G = new BinaryTreeNode<int> { Data = 17 };
            var H = new BinaryTreeNode<int> { Data = 13 };
            var I = new BinaryTreeNode<int> { Data = 43 };
            var J = new BinaryTreeNode<int> { Data = 23 };
            var K = new BinaryTreeNode<int> { Data = 37 };
            var L = new BinaryTreeNode<int> { Data = 29 };
            var M = new BinaryTreeNode<int> { Data = 31 };
            var N = new BinaryTreeNode<int> { Data = 41 };
            var O = new BinaryTreeNode<int> { Data = 47 };
            var P = new BinaryTreeNode<int> { Data = 53 };

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

            var result = Solution.IsBinaryTreeBinarySearchTreeWithQueue(A);

            result.Should().BeTrue();
        }
    }
}