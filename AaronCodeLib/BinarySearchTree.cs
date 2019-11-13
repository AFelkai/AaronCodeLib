using System;
using System.Collections.Generic;

namespace AaronCodeLib
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {

        private List<T> Traversal { set; get; }

        public BinaryTreeNode<T> Root { set; get; }

        public BinarySearchTree(BinaryTreeNode<T> node)
        {
            Root = node;
            Traversal = new List<T>();
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

        public List<T> Traverse()
        {

        }

        public List<T> PreOrderTraversal()
        {
            List<T> traversal = new List<T>();

            
        }
    }
}