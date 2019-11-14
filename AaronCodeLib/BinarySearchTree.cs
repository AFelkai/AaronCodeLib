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
                InsertAtProperSpot(val, Root);
        }

        private void InsertAtProperSpot(T val, BinaryTreeNode<T> node)
        {
            if (node.Value.CompareTo(val) >= 0) //If value is less than or equal to current node
            {
                if (node.Left != null)
                    InsertAtProperSpot(val, node.Left);
                else
                    node.Left = new BinaryTreeNode<T>(val);
            }

            else
            {
                if (node.Right != null)
                    InsertAtProperSpot(val, node.Right);
                else
                    node.Right = new BinaryTreeNode<T>(val);
            }
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

        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            throw new NotImplementedException();
        }

        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            throw new NotImplementedException();
        }


    }
}