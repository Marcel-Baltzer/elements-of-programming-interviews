namespace Elements_of_Programming_Interviews.BinaryTrees.RightSibling
{
    public class Solution
    {
        public static void ConstructRightSibling(BinaryTreeNodeWithNext<int> tree)
        {
            BinaryTreeNodeWithNext<int> leftStart = tree;

            while (leftStart != null && leftStart.Left != null)
            {
                PopulateLowerLevelNextField(leftStart);
                leftStart = leftStart.Left;
            }
        }

        private static void PopulateLowerLevelNextField(BinaryTreeNodeWithNext<int> startNode)
        {
            BinaryTreeNodeWithNext<int> iter = startNode;

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