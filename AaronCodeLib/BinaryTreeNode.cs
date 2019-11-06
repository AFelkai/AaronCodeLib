namespace AaronCodeLib
{
    public class BinaryTreeNode<T> : INode<T>
    {

        public T Value { set; get; }
        public BinaryTreeNode<T> Left { set; get; }
        public BinaryTreeNode<T> Right { set; get; }

        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T value)
        {
            Value = value;
        }


    }
}
