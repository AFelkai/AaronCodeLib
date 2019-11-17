using System;
using System.Collections.Generic;

namespace AaronCodeLib
{
    public class TrieNode<T> : INode<T>
    {
        public T Value { set; get; }
        public List<TrieNode<T>> Children { set; get; }
        public bool EndOfWord { set; get; }

        public TrieNode(T value)
        {
            Value = value;
            Children = new List<TrieNode<T>>();
            EndOfWord = false;
        }

        public TrieNode()
        {
            Children = new List<TrieNode<T>>();
            EndOfWord = false;
        }
    }
}