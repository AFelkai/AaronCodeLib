using System;
using AaronCodeLib;

namespace Testing
{
    class Test
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Insert(4);
            binaryTree.Insert(8);
            binaryTree.Insert(12);
            binaryTree.Insert(35);
            binaryTree.Insert(28);
            binaryTree.Insert(6);


            Console.WriteLine(binaryTree.Root.Right.Left.Value); //Should return 6
            Console.WriteLine();

            var binarySearchTree = new BinarySearchTree<double>(4);

            binarySearchTree.Insert(1029);
            binarySearchTree.Insert(408.42);
            binarySearchTree.Insert(92);
            binarySearchTree.Insert(3.9);
            binarySearchTree.Insert(87);
            binarySearchTree.Insert(.4282);
            binarySearchTree.Insert(2000);
            binarySearchTree.Insert(3.95);

            Console.WriteLine(binarySearchTree.Root.Right.Left.Left.Value); //Should return 92
            Console.WriteLine();

            foreach (var item in binarySearchTree.Traverse(Traversal.PreOrder))
            {
                Console.WriteLine(item); //Should return 4, 3.9, .4282, 3.5, 1029, 408.42, 92, 87, 2000
            }
            Console.WriteLine();

            foreach (var item in binarySearchTree.Traverse(Traversal.InOrder))
            {
                Console.WriteLine(item); //Should return .4282, 3.9, 3.95, 4, 87, 92, 408.42, 1029, 2000
            }
            Console.WriteLine();

            foreach (var item in binarySearchTree.Traverse(Traversal.PostOrder))
            {
                Console.WriteLine(item); //Should return .4282, 3.95, 3.9, 87, 92, 408.42, 2000, 1029, 4
            }

            Console.WriteLine(binarySearchTree.Exists(100));
            Console.WriteLine(binarySearchTree.Exists(87));

            var trie = new Trie();

            trie.Insert("cool");
            trie.Insert("cod");
            trie.Insert("hello");
            trie.Insert("hell");

            Console.WriteLine();
            Console.WriteLine(trie.FindWord("hell")); //Should return True
            Console.WriteLine(trie.FindWord("he")); //Should return False
            Console.WriteLine(trie.FindWord("coo")); //Should return False
            Console.WriteLine(trie.FindWord("cool")); //Should return True
        }
    }
}