namespace AaronCodeLib
{
    public class BinaryTree<T> : ITree<T>
    {

        public BinaryTreeNode<T> Root { set; get; }
        private BinaryTreeNode<T> CurrentNode { set; get; }
        private int _totalLeafsInCurrentLevel;
        private int _nextLeafNumber;

        public BinaryTree(BinaryTreeNode<T> node)
        {
            Root = node;
            CurrentNode = Root;
            _totalLeafsInCurrentLevel = 1;
            _nextLeafNumber = 1;
        }

        public BinaryTree(T val) : this(new BinaryTreeNode<T>(val))
        {
        }

        public BinaryTree() : this(null)
        {
        }

        public void Insert(T value) //Implemented in a "complete" fashion
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode<T>(value);
                CurrentNode = Root;
            }
            else if (CurrentNode.Left == null)
                CurrentNode.Left = new BinaryTreeNode<T>(value);
            else if (CurrentNode.Right == null)
            {
                CurrentNode.Right = new BinaryTreeNode<T>(value);

                if (_nextLeafNumber == _totalLeafsInCurrentLevel) //If we have to make a new level
                {
                    _totalLeafsInCurrentLevel *= 2;
                    _nextLeafNumber = 1;
                }
                else
                {
                    _nextLeafNumber++;
                }

                CurrentNode = GetNextLeafNode(Root, _totalLeafsInCurrentLevel / 2);
            }
        }

        public BinaryTreeNode<T> GetNextLeafNode(BinaryTreeNode<T> node, int halfLeafs, int rightOffset = 0)
        {
            if (node.Left != null)
            {
                return _nextLeafNumber - rightOffset <= halfLeafs ?
                    GetNextLeafNode(node.Left, halfLeafs / 2) :
                    GetNextLeafNode(node.Right, halfLeafs / 2, halfLeafs);
            }

            return node;
        }
    }
}