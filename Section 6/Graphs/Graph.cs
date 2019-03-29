using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class Graph
    {
        public List<Node> Nodes { get; set; } = new List<Node>();
    }

    public class Node
    {
        public int Id { get; set; }

        public List<Node> Children { get; set; }

        public Node(int value, params Node[] children)
        {
            Id = value;
            Children = new List<Node>(children);
        }
    }
}
