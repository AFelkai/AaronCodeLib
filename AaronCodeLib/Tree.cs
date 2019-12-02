using System;
using System.Collections.Generic;
using System.Text;

namespace AaronCodeLib
{
    class Tree<T> : ITree<T>
    {

        public TreeNode<T> Root { get; }

        public Tree() : this(new TreeNode<T>())
        {
        }

        public Tree(TreeNode<T> root)
        {
            Root = root;
        }

        public void Insert(TreeNode<T> position, T value)
        {
            position.Children.Add(new TreeNode<T>(value));
            position.IsLeaf = false;
        }
    }
}
