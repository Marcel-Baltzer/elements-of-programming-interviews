using System.Collections.Generic;
using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._05._ReconstructFromTraversalData
{
    public class Solution
    {
        //SolutionOne
        
        public static BinarySearchTreeNode<int> RebuildBinarySearchTreeFromPreOrder(List<int> preorderSequence)
        {
            return RebuildBinarySearchTreeFromPreOrderHelper(preorderSequence, 0, preorderSequence.Count);
        }
        
        // Builds a BST from preorderSequence.subList(start , end).
        private static BinarySearchTreeNode<int> RebuildBinarySearchTreeFromPreOrderHelper(IReadOnlyList<int> preorderSequence,
                                                                                            int start, int end)
        {
            if (start >= end)
            {
                return null;
            }

            var transitionPoint = start + 1;

            while (transitionPoint < end 
                   && preorderSequence[transitionPoint].CompareTo(preorderSequence[start]) < 0)
            {
                ++transitionPoint;
            }

            return new BinarySearchTreeNode<int>
            {
                Data = preorderSequence[start],
                Left = RebuildBinarySearchTreeFromPreOrderHelper(preorderSequence, start + 1, transitionPoint),
                Right = RebuildBinarySearchTreeFromPreOrderHelper(preorderSequence, transitionPoint, end)
            };
        }
        
        //SolutionTwo
        
        // Global variable , tracks current subtree.
        private static int _rootIdx;
        
        public static BinarySearchTreeNode<int> RebuildBinarySearchTreeFromPreOrderOnValueRange(List<int> preorderSequence)
        {
            _rootIdx = 0;
            return RebuildBinarySearchTreeFromPreOrderOnValueRangeHelper(preorderSequence, int.MinValue, int.MaxValue);
        }
        
        // Builds a BST on the subtree rooted at rootIdx from preorderSequence on keys
        // in (lowerBound, upperBound).
        private static BinarySearchTreeNode<int> RebuildBinarySearchTreeFromPreOrderOnValueRangeHelper(
            IReadOnlyList<int> preorderSequence, int lowerBound, int upperBound)
        {
            if (_rootIdx >= preorderSequence.Count)
            {
                return null;
            }

            var root = preorderSequence[_rootIdx];
            if (root < lowerBound || root > upperBound)
            {
                return null;
            }

            ++_rootIdx;
            // Note that RebuildBinarySearchTreeFromPreOrderOnValueRangeHelper updates rootIdx. So the order
            // of following two calls are critical.
            var leftSubtree = 
                RebuildBinarySearchTreeFromPreOrderOnValueRangeHelper(preorderSequence, lowerBound, root);
            var rightSubtree = 
                RebuildBinarySearchTreeFromPreOrderOnValueRangeHelper(preorderSequence, root, upperBound);

            return new BinarySearchTreeNode<int>
            {
                Data = root,
                Left = leftSubtree,
                Right = rightSubtree
            };
        }
    }
}