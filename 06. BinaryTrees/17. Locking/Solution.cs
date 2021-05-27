namespace Elements_of_Programming_Interviews._06._BinaryTrees._17._Locking
{
    public class Solution
    {
        public class BinaryTree
        {
            public BinaryTree Left, Right, Parent;
            private bool locked = false;
            private int numLockedDescendants = 0;

            public bool IsLocked() { return locked; }

            public bool Lock()
            {
                // We cannot lock if any of this node’s descendants are locked.
                if (numLockedDescendants > 0 || locked)
                {
                    return false;
                }

                // We cannot lock if any of this node’s ancestors are locked.
                for (BinaryTree iter = Parent; iter != null; iter = iter.Parent)
                {
                    if (iter.locked)
                    {
                        return false;
                    }
                }

                // Lock this node and increments all its ancestors’s descendant lock
                // counts.
                locked = true;
                for (BinaryTree iter = Parent; iter != null; iter = iter.Parent)
                {
                    iter.numLockedDescendants++;
                }

                return true;
            }

            public void Unlock()
            {
                if (locked)
                {
                    // Unlocks itself and decrements its ancestors ’s descendant lock counts.
                    locked = false;

                    for (BinaryTree iter = Parent; iter != null; iter = iter.Parent)
                    {
                        iter.numLockedDescendants--;
                    }
                }
            }
        }
    }
}