namespace AaronCodeLib
{
    public class Trie : ITree<char>
    {

        public INode<char> Root { set; get; }
        public bool IsLeaf { set; get; }

        Trie()
        {

            Root = new TreeNode<char>();
            IsLeaf = true;
        }

        void AddWord(string word)
        {
            //Root.Value
        }
    }
}