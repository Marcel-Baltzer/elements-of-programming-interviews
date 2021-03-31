using System.Security.AccessControl;
namespace Elements_of_Programming_Interviews.BinaryTrees
{
    public class BinaryTreeNodeWithSize<T>
    {
        public T Data;
        public int Size { get { return (Left != null ? Left.Size : 0) + (Right != null ? Right.Size : 0) + 1; } }
        public BinaryTreeNodeWithSize<T> Left, Right;
    }
}