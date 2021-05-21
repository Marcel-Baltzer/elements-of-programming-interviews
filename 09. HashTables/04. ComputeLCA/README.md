## 4. Compute the LCA, optimizing for close ancestors

Problem LCA in BinaryTrees is concerned with computing the LCA in a binary tree with parent pointers in time proportional to the height of the tree. The algorithm presented in Solution LCA in BinaryTrees entails traversing all the way to the root even if the nodes whose LCA is being computed are very close to their LCA.

Design an algorithm for computing the LCA of two nodes in a binary tree. The algorithm's time complexity should depend only on the distance from the nodes to the LCA.

> Hint: Focus on the extreme case described in the problem introduction.