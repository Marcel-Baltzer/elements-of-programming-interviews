using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._12._Recursion._08._BinaryTrees
{
    public static class Solution
    {
        public static List<BinaryTreeNode<int>> GenerateAllBinaryTrees(int numNodes)
        {
            var result = new List<BinaryTreeNode<int>>();
            // Empty tree, add as an null.
            if (numNodes == 0)
            {
                result.Add(null);
            }

            for (var numLeftTreeNodes = 0; numLeftTreeNodes < numNodes; ++numLeftTreeNodes)
            {
                var numRightTreeNodes = numNodes - 1 - numLeftTreeNodes;
                var leftSubtrees = GenerateAllBinaryTrees(numLeftTreeNodes);
                var rightSubtrees = GenerateAllBinaryTrees(numRightTreeNodes);

                // Generates all combinations of leftSubtrees and rightSubtrees.
                foreach (var leftSubtree in leftSubtrees)
                {
                    foreach (var rightSubtree in rightSubtrees)
                    {
                        result.Add(new BinaryTreeNode<int>
                        {
                            Data = 0,
                            Left = leftSubtree,
                            Right = rightSubtree
                        });
                    }
                }
            }

            return result;
        }
    }
}