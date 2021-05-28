using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._12._ReconstructTraversalData
{
    public class Tests
    {
        [Fact]
        public void BinaryTreeFromPreorderInorder()
        {
            var inorder = new List<int> { 561, 6, 314, 0, 17, 271, 28, 9, 3 };
            var preorder = new List<int> { 17, 6, 561, 0, 314, 271, 28, 3, 9 };

            var result = Solution.BinaryTreeFromPreorderInorder(preorder, inorder);

            var A = new BinaryTreeNode<int>() { Data = 314 };
            var B = new BinaryTreeNode<int>() { Data = 6 };
            var C = new BinaryTreeNode<int>() { Data = 271 };
            var D = new BinaryTreeNode<int>() { Data = 28 };
            var E = new BinaryTreeNode<int>() { Data = 0 };
            var F = new BinaryTreeNode<int>() { Data = 561 };
            var G = new BinaryTreeNode<int>() { Data = 3 };
            var H = new BinaryTreeNode<int>() { Data = 17 };
            var I = new BinaryTreeNode<int>() { Data = 9 };

            H.Left = B;
            H.Right = C;
            B.Left = F;
            B.Right = E;
            E.Left = A;
            C.Right = D;
            D.Right = G;
            G.Left = I;

            result.Should().BeEquivalentTo(H);
        }
    }
}