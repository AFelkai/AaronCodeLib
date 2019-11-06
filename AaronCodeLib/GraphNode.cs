using System.Collections.Generic;

namespace AaronCodeLib
{
    public class GraphNode<T> : INode<T>
    {

        public T Value { set; get; }
        public List<GraphNode<T>> AdjacentNodes { set; get; }

        public GraphNode(T value)
        {
            Value = value;
            AdjacentNodes = new List<GraphNode<T>>();
        }

        public GraphNode()
        {
            Value = default;
            AdjacentNodes = new List<GraphNode<T>>();
        }
    }
}