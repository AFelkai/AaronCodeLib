using System;
using System.Collections.Generic;
using System.Text;

namespace AaronCodeLib
{
    class Tree<T> : ITree<T> where T : IComparable<T>
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

        //public bool Search(SearchType type, T val)
        //{

        //}

        //public List<TreeNode<T>> Search(SearchType type)
        //{

        //}

        private bool BFS(T val, TreeNode<T> node)
        {
            if (node.Value.CompareTo(val) == 0)
                return true;
            throw new NotImplementedException();
        }

        //private bool DFS(T val, TreeNode<T> node)
        //{

        //}

        //private List<TreeNode<T>> BFS(TreeNode<T> node)
        //{

        //}

        //private List<TreeNode<T>> DFS(TreeNode<T> node)
        //{

        //}

    }
}
