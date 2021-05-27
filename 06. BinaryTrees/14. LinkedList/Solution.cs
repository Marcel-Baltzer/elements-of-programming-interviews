using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._14._LinkedList
{
    public class Solution
    {
        public static List<BinaryTreeNode<int>> CreateListOfLeaves(BinaryTreeNode<int> tree)
        {
            var leaves = new List<BinaryTreeNode<int>>();

            AddLeavesLeftToRight(tree, leaves);

            return leaves;
        }

        private static void AddLeavesLeftToRight(BinaryTreeNode<int> tree, List<BinaryTreeNode<int>> leaves)
        {
            if (tree != null)
            {
                if (tree.Left == null && tree.Right == null)
                {
                    leaves.Add(tree);
                }
                else
                {
                    AddLeavesLeftToRight(tree.Left, leaves);
                    AddLeavesLeftToRight(tree.Right, leaves);
                }
            }
        }
    }
}