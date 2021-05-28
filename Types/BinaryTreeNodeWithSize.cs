namespace Elements_of_Programming_Interviews.Types
{
    public class BinaryTreeNodeWithSize<T>
    {
        public T Data;
        public int Size => (Left?.Size ?? 0) + (Right?.Size ?? 0) + 1;
        public BinaryTreeNodeWithSize<T> Left, Right;
    }
}