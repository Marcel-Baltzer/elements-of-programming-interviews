using System.Collections.Generic;

namespace Elements_of_Programming_Interviews.StacksAndQueues.ComputeBinaryTree
{
    public class Solution
    {
        public class BinaryTreeNode<T>
        {
            public T Data;
            public BinaryTreeNode<T> Left, Right;
        }

        public static List<List<int>> BinaryTreeDepthOrder(BinaryTreeNode<int> tree)
        {
            Queue<BinaryTreeNode<int>> currDepthNodes = new Queue<BinaryTreeNode<int>>();
            currDepthNodes.Enqueue(tree);
            List<List<int>> result = new List<List<int>>();

            while (currDepthNodes.Count > 0)
            {
                Queue<BinaryTreeNode<int>> nextDepthNodes = new Queue<BinaryTreeNode<int>>();
                List<int> thisLevel = new List<int>();

                while (currDepthNodes.Count > 0)
                {
                    BinaryTreeNode<int> curr = currDepthNodes.Dequeue();

                    if (curr != null)
                    {
                        thisLevel.Add(curr.Data);

                        // Defer the null checks to the null test above.
                        nextDepthNodes.Enqueue(curr.Left);
                        nextDepthNodes.Enqueue(curr.Right);
                    }
                }

                if (thisLevel.Count > 0)
                {
                    result.Add(thisLevel);
                }
                currDepthNodes = nextDepthNodes;
            }

            return result;
        }
    }
}