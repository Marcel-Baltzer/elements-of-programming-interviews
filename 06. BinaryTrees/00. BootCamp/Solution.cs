using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._06._BinaryTrees._00._BootCamp
{
    public class Solution
    {
        public static void TreeTraversal(BinaryTreeNode<int> root)
        {
            if (root != null)
            {
                // Preorder: Processes the root before the traversals of left and right
                // children.
                System.Console.WriteLine($"Preorder: {root.Data}");
                TreeTraversal(root.Left);
                // Inorder: Processes the root after the traversal of left child and
                // before the traversal of right child.
                System.Console.WriteLine($"Inorder: {root.Data}");
                TreeTraversal(root.Right);
                // Postorder: Processes the root after the traversals of left and right
                // children.
                System.Console.WriteLine($"Postorder: {root.Data}");
            }
        }
    }
}