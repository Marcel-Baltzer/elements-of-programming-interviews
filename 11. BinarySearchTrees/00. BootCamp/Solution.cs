using Elements_of_Programming_Interviews.Types;

namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._00._BootCamp
{
    public class Solution
    {
        public static BinarySearchTreeNode<int> SearchBinarySearchTree(BinarySearchTreeNode<int> tree, int key)
        {
            if (tree == null || tree.Data == key)
            {
                return tree;
            }

            return key < tree.Data
                ? SearchBinarySearchTree(tree.Left, key)
                : SearchBinarySearchTree(tree.Right, key);
        }
    }
}