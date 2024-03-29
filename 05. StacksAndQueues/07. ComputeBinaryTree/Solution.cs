using System.Collections.Generic;

namespace Elements_of_Programming_Interviews._05._StacksAndQueues._07._ComputeBinaryTree
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
            var currDepthNodes = new Queue<BinaryTreeNode<int>>();
            currDepthNodes.Enqueue(tree);
            var result = new List<List<int>>();

            while (currDepthNodes.Count > 0)
            {
                var nextDepthNodes = new Queue<BinaryTreeNode<int>>();
                var thisLevel = new List<int>();

                while (currDepthNodes.Count > 0)
                {
                    var curr = currDepthNodes.Dequeue();

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