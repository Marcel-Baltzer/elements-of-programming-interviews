using System;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._01._HeightBalanced
{
    public class Solution
    {
        private class BalanceStatusWithHeight
        {
            public BalanceStatusWithHeight(bool balanced, int height)
            {
                Balanced = balanced;
                Height = height;
            }

            public bool Balanced { get; }

            public int Height { get; }
        }

        public static bool IsBalanced(BinaryTreeNode<int> tree)
        {
            return CheckBalanced(tree).Balanced;
        }

        private static BalanceStatusWithHeight CheckBalanced(BinaryTreeNode<int> tree)
        {
            if (tree == null)
            {
                return new BalanceStatusWithHeight(true, -1); // Base case.
            }

            var leftResult = CheckBalanced(tree.Left);
            if (!leftResult.Balanced)
            {
                return leftResult; // Left subtree is not balanced.
            }

            var rightResult = CheckBalanced(tree.Right);
            {
                if (!rightResult.Balanced)
                {
                    return rightResult; // Right subtree is not balanced.
                }
            }

            var isBalanced = Math.Abs(leftResult.Height - rightResult.Height) <= 1;
            var height = Math.Max(leftResult.Height, rightResult.Height) + 1;

            return new BalanceStatusWithHeight(isBalanced, height);
        }
    }
}