using System.Collections.Generic;
using System.Linq;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._01._SatisfyBinaryTree
{
    public class Solution
    {
        //SolutionOne
        
        public static bool IsBinaryTreeBinarySearchTree(BinaryTreeNode<int> tree)
        {
            return AreKeysInRange(tree, int.MinValue, int.MaxValue);
        }

        private static bool AreKeysInRange(BinaryTreeNode<int> tree, int lower, int upper)
        {
            if (tree == null)
            {
                return true;
            }

            if (tree.Data.CompareTo(lower) < 0 || tree.Data.CompareTo(upper) > 0)
            {
                return false;
            }

            return AreKeysInRange(tree.Left, lower, tree.Data)
                   && AreKeysInRange(tree.Right, tree.Data, upper);
        }
        
        //SolutionTwo

        private class QueueEntry
        {
            public readonly BinaryTreeNode<int> TreeNode;
            public readonly int LowerBound;
            public readonly int UpperBound;

            public QueueEntry(BinaryTreeNode<int> treeNode, int lowerBound, int upperBound)
            {
                TreeNode = treeNode;
                LowerBound = lowerBound;
                UpperBound = upperBound;
            }
        }

        public static bool IsBinaryTreeBinarySearchTreeWithQueue(BinaryTreeNode<int> tree)
        {
            var binarySearchTreeQueue = new Queue<QueueEntry>();
            binarySearchTreeQueue.Enqueue(new QueueEntry(tree, int.MinValue, int.MaxValue));

            while (binarySearchTreeQueue.Any())
            {
                var headEntry = binarySearchTreeQueue.Dequeue();

                if (headEntry.TreeNode == null)
                {
                    continue;
                }
                
                if (headEntry.TreeNode.Data < headEntry.LowerBound
                    || headEntry.TreeNode.Data > headEntry.UpperBound)
                {
                    return false;
                }
                    
                binarySearchTreeQueue.Enqueue(
                    new QueueEntry(headEntry.TreeNode.Left, headEntry.LowerBound,headEntry.TreeNode.Data));
                    
                binarySearchTreeQueue.Enqueue(
                    new QueueEntry(headEntry.TreeNode.Right, headEntry.TreeNode.Data,headEntry.UpperBound));
            }
            
            return true;
        }
    }
}