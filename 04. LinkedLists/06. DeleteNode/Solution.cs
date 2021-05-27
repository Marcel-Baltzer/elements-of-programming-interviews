namespace Elements_of_Programming_Interviews._04._LinkedLists._06._DeleteNode
{
    public class Solution
    {
        //Assumes nodeToDelete is not tail.
        public static void DeletionFromList(ListNode<int> nodeToDelete)
        {
            nodeToDelete.Data = nodeToDelete.Next.Data;
            nodeToDelete.Next = nodeToDelete.Next.Next;
        }
    }
}