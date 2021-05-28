namespace Elements_of_Programming_Interviews.Types
{
    public class BinaryTreeNodeWithParent<T>
    {
        public T Data;
        public BinaryTreeNodeWithParent<T> Parent;
        public BinaryTreeNodeWithParent<T> Left, Right;
    }
}