## 17. Implement locking in a binary tree

This problem is concerned with the design of an API for setting the state of nodes in a binary tree to lock or unlock. A node's state cannot be set to lock if any of its descendants or ancestors are in lock.

Changing a node's state to lock does not change the state of any other nodes. For example, all leaves may simultaneously be in state lock. (If this is the case, no nonleaf nodes can be in state lock.)

Write the following methods for a binary tree node class:

1. A function to test if the node is locked.
2. A function to lock the node. If the node cannot be locked, return false, otherwise lock it and return true.
3. A function to unlock the node.

Assume that each node has a parent field. The API will be used in a single threaded program, so there is no need for concurrency constructs such as mutexes or synchronization.

> Hint: Track the number of locked nodes for each subtree.
