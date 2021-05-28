using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._09._MinimumHeightTreeFromArray
{
    public class Tests
    {
        [Fact]
        public void BuildMinHeightBinarySearchTreeFromSortedArray()
        {
            var list = new List<int> {2, 3, 5, 7, 11, 13, 17, 19, 23};

            var result = Solution.BuildMinHeightBinarySearchTreeFromSortedArray(list);

            var A = new BinarySearchTreeNode<int> {Data = 11};           
            var B = new BinarySearchTreeNode<int> {Data = 5};
            var C = new BinarySearchTreeNode<int> {Data = 3};
            var D = new BinarySearchTreeNode<int> {Data = 2};
            var E = new BinarySearchTreeNode<int> {Data = 7};
            var F = new BinarySearchTreeNode<int> {Data = 19};
            var G = new BinarySearchTreeNode<int> {Data = 17};
            var H = new BinarySearchTreeNode<int> {Data = 13};
            var I = new BinarySearchTreeNode<int> {Data = 23};

            A.Left = B;
            B.Left = C;
            C.Left = D;
            B.Right = E;

            A.Right = F;
            F.Left = G;
            G.Left = H;
            F.Right = I;

            result.Should().BeEquivalentTo(A);
        }
    }
}