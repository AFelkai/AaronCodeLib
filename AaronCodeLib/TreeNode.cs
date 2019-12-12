using System;
using System.Collections.Generic;

namespace AaronCodeLib
{
    public class TreeNode<T> : INode<T> where T : IComparable<T>
    {

        public T Value { set; get; }
        public List<INode<T>> Children { set; get; }
        public bool IsLeaf { get; set; }

        public TreeNode()
        {
        }

        public TreeNode(T value)
        {
            Value = value;
            Children = new List<INode<T>>();
            IsLeaf = true;
        }
    }
}