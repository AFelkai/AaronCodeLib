namespace AaronCodeLib
{
    class Graph<T>
    {
        public GraphNode<T> Root { get; set; }

        Graph(GraphNode<T> node)
        {
            Root = node;
        }

        Graph() : this(new GraphNode<T>())
        {
        }
    }
}