using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._08._BinaryTrees
{
    public class Tests
    {
        [Fact]
        public void GenerateAllBinaryTrees()
        {
            var result = Solution.GenerateAllBinaryTrees(3);

            var expectedResult = new List<BinaryTreeNode<int>>
            {
                new()
                {
                    Right = new BinaryTreeNode<int>
                    {
                        Right = new BinaryTreeNode<int>()
                    }
                },
                new()
                {
                    Right = new BinaryTreeNode<int>
                    {
                        Left = new BinaryTreeNode<int>()
                    }
                },
                new()
                {
                    Left = new BinaryTreeNode<int>(),
                    Right = new BinaryTreeNode<int>()
                },
                new()
                {
                    Left = new BinaryTreeNode<int>
                    {
                        Right = new BinaryTreeNode<int>()
                    }
                },
                new()
                {
                    Left = new BinaryTreeNode<int>
                    {
                        Left = new BinaryTreeNode<int>()
                    }
                }
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}