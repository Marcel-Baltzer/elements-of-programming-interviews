namespace Elements_of_Programming_Interviews._11._BinarySearchTrees._10._InsertionAndDeletion
{
    public class Solution
    {
        public class BinarySearchTree
        {
            private class TreeNode
            {
                public int Data;
                public TreeNode Left, Right;

                public TreeNode(int data, TreeNode left, TreeNode right)
                {
                    Data = data;
                    Left = left;
                    Right = right;
                }
            }

            private TreeNode root;

            public bool Insert(int key)
            {
                if (root == null)
                {
                    root = new TreeNode(key, null, null);
                }
                else
                {
                    var curr = root;
                    var parent = curr;

                    while (curr != null)
                    {
                        parent = curr;
                        var cmp = key.CompareTo(curr.Data);
                        
                        if (cmp == 0)
                        {
                            // key already present, no duplicates to be added.
                            return false;
                        }

                        if (cmp < 0)
                        {
                            curr = curr.Left;
                        }
                        else
                        {
                            curr = curr.Right;
                        }
                    }
                    
                    // Insert key according to key and parent.
                    if (key.CompareTo(parent.Data) < 0)
                    {
                        parent.Left = new TreeNode(key, null, null);
                    }
                    else
                    {
                        parent.Right = new TreeNode(key, null, null);
                    }
                }

                return true;
            }

            public bool Delete(int key)
            {
                // Find the node with key.
                var curr = root;
                TreeNode parent = null;

                while (curr != null && curr.Data.CompareTo(key) != 0)
                {
                    parent = curr;
                    curr = key.CompareTo(curr.Data) < 0 ? curr.Left : curr.Right;
                }

                if (curr == null)
                {
                    // There’s no node with key in this tree.
                    return false;
                }

                var keyNode = curr;
                if (keyNode.Right != null)
                {
                    // Find the minimum of the right subtree.
                    var rightKeyNode = keyNode.Right;
                    var rightParent = keyNode;
                    
                    while (rightKeyNode.Left != null)
                    {
                        rightParent = rightKeyNode;
                        rightKeyNode = rightKeyNode.Left;
                    }

                    keyNode.Data = rightKeyNode.Data;
                    // Move links to erase the node.
                    if(rightParent.Left == rightKeyNode)
                    {
                        rightParent.Left = rightKeyNode.Right;
                    }
                    else // rightParent.left != rightKeyNode.
                    {
                        rightParent.Right = rightKeyNode.Right;
                    }

                    rightKeyNode.Right = null;
                }
                else
                {
                    // Update root link if needed.
                    if (root == keyNode)
                    {
                        root = keyNode.Left;
                        keyNode.Left = null;
                    }
                    else
                    {
                        if (parent == null)
                        {
                            return false;
                        }
                        
                        if (parent.Left == keyNode)
                        {
                            parent.Left = keyNode.Left;
                        }
                        else
                        {
                            parent.Right = keyNode.Left;
                        }

                        keyNode.Left = null;
                    }
                }
                
                return true;
            }
        }
    }
}