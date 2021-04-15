namespace Elements_of_Programming_Interviews.BinaryTrees.BootCamp
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