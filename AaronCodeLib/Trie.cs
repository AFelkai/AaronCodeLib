using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace AaronCodeLib
{
    public class Trie : ITree<char>
    {

        private TrieNode<char> Root { get; }

        public Trie()
        {
            Root = new TrieNode<char>();
        }

        public void Insert(string word)
        {
            AddWord(word, Root);
        }

        private TrieNode<char> AddWord(string word, TrieNode<char> node)
        {
            var item = node.Children.FirstOrDefault(child => child.Value == word.FirstOrDefault());

            if (item != null && word != "")
            {
                return AddWord(word.Substring(1), item);
            }

            foreach (char c in word)
            {
                node.Children.Add(new TrieNode<char>(c));
                node = node.Children.First(child => child.Value == c);
            }

            node.EndOfWord = true;
            return node;
        }

        public bool FindWord(string word)
        {
            var node = Root;
            foreach (char c in word)
            {
                if (node.Children.FirstOrDefault(child => child.Value == c) != null)
                    node = node.Children.First(child => child.Value == c);
                else 
                    return false;
            }

            return node.EndOfWord;
        }
    }
}