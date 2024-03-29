using System;
using System.Collections.Generic;

namespace AaronCodeLib
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { set; get; }
        private List<T> Traversed { set; get; }

        public BinarySearchTree(BinaryTreeNode<T> node)
        {
            Root = node;
            Traversed = new List<T>();
        }

        public BinarySearchTree(T value) : this(new BinaryTreeNode<T>(value))
        {
        }

        public BinarySearchTree() : this(null)
        {
        }

        public void Insert(T val)
        {
            if (Root == null) //If it's the first node in the tree
                Root = new BinaryTreeNode<T>(val);
            else
                Insert(val, Root);
        }

        private static void Insert(T val, BinaryTreeNode<T> node)
        {
            if (node.Value.CompareTo(val) >= 0) //If value is less than or equal to current node
            {
                if (node.Left != null)
                    Insert(val, node.Left);
                else
                    node.Left = new BinaryTreeNode<T>(val);
            }

            else
            {
                if (node.Right != null)
                    Insert(val, node.Right);
                else
                    node.Right = new BinaryTreeNode<T>(val);
            }
        }

        public bool Exists(T val)
        {
            return Exists(val, Root);
        }

        private bool Exists(T val, BinaryTreeNode<T> node)
        {
            if (val.CompareTo(node.Value) == 0)
                return true;
            if (val.CompareTo(node.Value) < 0)
            {
                if (node.Left != null)
                    return Exists(val, node.Left);
                return false;
            }

            if (node.Right != null) //Else
                return Exists(val, node.Right);
            return false;

        }

        public List<T> Traverse(Traversal traversalType = Traversal.InOrder)
        {
            Traversed = new List<T>();

            switch (traversalType)
            {
                case Traversal.PreOrder:
                    {
                        PreOrderTraversal(Root);
                        return Traversed;
                    }
                case Traversal.InOrder:
                    {
                        InOrderTraversal(Root);
                        return Traversed;
                    }
                case Traversal.PostOrder:
                    {
                        PostOrderTraversal(Root);
                        return Traversed;
                    }
            }
            return new List<T>();
        }

        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Traversed.Add(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Traversed.Add(node.Value);
                InOrderTraversal(node.Right);
            }
        }

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Traversed.Add(node.Value);
            }
        }
    }
}