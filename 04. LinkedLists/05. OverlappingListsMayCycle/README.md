## 5. Test for overlapping lists-lists may have cycles

Solve Problem 04 for the case where the lists may each or both have a cycle. If such a node exists, return a node that appears first when traversing the lists. This node may not be unique—if one node ends in a cycle, the first cycle node encountered when traversing it may be different from the first cycle node encountered when traversing the second list, even though the cycle is the same. In such cases, you may return either of the two nodes.

> Hint: Use case analysis. What if both lists have cycles? What if they end in a common cycle? What if one list has cycle and the other does not?
