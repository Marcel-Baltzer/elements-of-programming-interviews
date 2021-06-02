using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Elements_of_Programming_Interviews._12._Recursion._11._DiameterOfATree
{
    public class Tests
    {
        [Fact]
        public void ComputeDiameter()
        {
            var leftThree = new Solution.Edge(6);
            var leftTwo = new Solution.Edge(4);
            leftTwo.Root.Edges = new List<Solution.Edge> {leftThree};
            var leftOne = new Solution.Edge(7);
            leftOne.Root.Edges = new List<Solution.Edge> {leftTwo};

            var rightFive = new Solution.Edge(3);
            var rightFour = new Solution.Edge(2);
            rightFour.Root.Edges = new List<Solution.Edge> {rightFive};
            var rightThree = new Solution.Edge(4);
            rightThree.Root.Edges = new List<Solution.Edge> {rightFour};
            var rightTwo = new Solution.Edge(1);
            rightTwo.Root.Edges = new List<Solution.Edge> {rightThree};
            var rightOne = new Solution.Edge(3);
            rightOne.Root.Edges = new List<Solution.Edge> {rightTwo};

            var mid = new Solution.Edge(14);

            var root = new Solution.Edge(0);
            root.Root.Edges = new List<Solution.Edge> {leftOne, mid, rightOne};

            var result = Solution.ComputeDiameter(new Solution.TreeNode(new List<Solution.Edge> {root}));

            result.Should().Be(31);
        }
    }
}