using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._16._RightSibling
{
    public class Solution
    {
        public static void ConstructRightSibling(BinaryTreeNodeWithNext<int> tree)
        {
            var leftStart = tree;

            while (leftStart != null && leftStart.Left != null)
            {
                PopulateLowerLevelNextField(leftStart);
                leftStart = leftStart.Left;
            }
        }

        private static void PopulateLowerLevelNextField(BinaryTreeNodeWithNext<int> startNode)
        {
            var iter = startNode;

            while (iter != null)
            {
                // Populate left child’s next field.
                iter.Left.Next = iter.Right;

                // Populate right child’s next field if iter is not the last node of this
                // level.
                if (iter.Next != null)
                {
                    iter.Right.Next = iter.Next.Left;
                }

                iter = iter.Next;
            }
        }
    }
}