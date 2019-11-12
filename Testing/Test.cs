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

            var binarySearchTree = new BinarySearchTree<double>(4);

            binarySearchTree.Insert(1029);
            binarySearchTree.Insert(408.42);
            binarySearchTree.Insert(92);
            binarySearchTree.Insert(3.9);
            binarySearchTree.Insert(87);
            binarySearchTree.Insert(.4282);

            Console.WriteLine(binarySearchTree.Root.Right.Left.Left.Value); //Should return 92
        }
    }
}
