using System.Collections.Generic;

namespace AaronCodeLib
{
    public class TreeNode<T> : INode<T>
    {

        public T Value { set; get; }
        public List<INode<T>> Children { set; get; }

        public TreeNode()
        {
        }

        public TreeNode(T value)
        {
            Value = value;
        }

    }
}