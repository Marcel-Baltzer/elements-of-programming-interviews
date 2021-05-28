using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._05._ReconstructFromTraversalData
{
    public class Tests
    {
        [Fact]
        public void RebuildBinarySearchTreeFromPreOrder()
        {
            var list = new List<int> {43, 23, 37, 29, 31, 41, 47, 53};

            var result = Solution.RebuildBinarySearchTreeFromPreOrder(list);
            
            var I = new BinarySearchTreeNode<int> { Data = 43 };
            var J = new BinarySearchTreeNode<int> { Data = 23 };
            var K = new BinarySearchTreeNode<int> { Data = 37 };
            var L = new BinarySearchTreeNode<int> { Data = 29 };
            var M = new BinarySearchTreeNode<int> { Data = 31 };
            var N = new BinarySearchTreeNode<int> { Data = 41 };
            var O = new BinarySearchTreeNode<int> { Data = 47 };
            var P = new BinarySearchTreeNode<int> { Data = 53 };
            
            I.Left = J;
            J.Right = K;
            K.Left = L;
            L.Right = M;
            K.Right = N;
            I.Right = O;
            O.Right = P;
            
            result.Should().BeEquivalentTo(I);
        }
        
        [Fact]
        public void RebuildBinarySearchTreeFromPreOrderOnValueRange()
        {
            var list = new List<int> {43, 23, 37, 29, 31, 41, 47, 53};

            var result = Solution.RebuildBinarySearchTreeFromPreOrderOnValueRange(list);
            
            var I = new BinarySearchTreeNode<int> { Data = 43 };
            var J = new BinarySearchTreeNode<int> { Data = 23 };
            var K = new BinarySearchTreeNode<int> { Data = 37 };
            var L = new BinarySearchTreeNode<int> { Data = 29 };
            var M = new BinarySearchTreeNode<int> { Data = 31 };
            var N = new BinarySearchTreeNode<int> { Data = 41 };
            var O = new BinarySearchTreeNode<int> { Data = 47 };
            var P = new BinarySearchTreeNode<int> { Data = 53 };
            
            I.Left = J;
            J.Right = K;
            K.Left = L;
            L.Right = M;
            K.Right = N;
            I.Right = O;
            O.Right = P;
            
            result.Should().BeEquivalentTo(I);
        }
    }
}