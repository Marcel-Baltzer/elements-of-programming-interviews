## 16. Compute the right sibling tree

For this problem, assume that each binary tree node has a extra field, call it level-next, that holds a binary tree node (this field is distinct from the fields for the left and right children). The level-next field will be used to compute a map from nodes to their right siblings. The input is assumed to be perfect binary tree.

Write a program that takes a perfect binary tree, and sets each node's level-next field to the node on its right, if one exists.

> Hint: Think of an appropriate traversal order.
