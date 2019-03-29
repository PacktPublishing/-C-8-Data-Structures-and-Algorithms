using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var g = CreateGraph();

            DepthFirstSearch(g);
            BreadthFirstSearch(g);
        }

        static void DepthFirstSearch(Graph g)
        {
            var visited = new HashSet<int>();
            bool isFirstElement = true;

            foreach (var n in g.Nodes)
            {
                Console.Write("[");
                isFirstElement = true;
                Dfs(n);
                Console.WriteLine("]");
            }

            void Dfs(Node node)
            {
                if (null == node) return;
                if (visited.Contains(node.Id)) return;

                if (!isFirstElement) Console.Write(", ");
                Console.Write(node.Id);
                visited.Add(node.Id);
                isFirstElement = false;

                foreach(var n in node.Children)
                {
                    if(!visited.Contains(n.Id))
                    {
                        Dfs(n);
                    }
                }
            }
        }

        static void BreadthFirstSearch(Graph g)
        {
            var visited = new HashSet<int>();
            bool isFirstElement = true;

            foreach (var n in g.Nodes)
            {
                Console.Write("[");
                isFirstElement = true;
                Bfs(n);
                Console.WriteLine("]");
            }

            void Bfs(Node rootNode)
            {
                var q = new Queue<Node>();
                visited.Add(rootNode.Id);
                q.Enqueue(rootNode);

                while (q.Count > 0)
                {
                    Node n = q.Dequeue();
                    if (!isFirstElement) Console.Write(", ");
                    Console.Write(n.Id);
                    isFirstElement = false;

                    foreach (var child in n.Children)
                    {
                        if (!visited.Contains(child.Id))
                        {
                            visited.Add(child.Id);
                            q.Enqueue(child);
                        }
                    }
                }
            }
        }

        static Graph CreateGraph()
        {
            var g = new Graph();

            // create nodes
            var nodes = new List<Node>();
            for (int i = 1; i < 8; i++)
            {
                nodes.Add(new Node(i));
            }

            // create connections
            nodes[0].Children.Add(nodes[1]);
            nodes[1].Children.AddRange(new[] { nodes[0], nodes[2], nodes[6] });
            nodes[2].Children.Add(nodes[5]);
            nodes[3].Children.Add(nodes[2]);
            nodes[4].Children.AddRange(new[] { nodes[3], nodes[5], nodes[6] });
            nodes[5].Children.AddRange(new[] { nodes[2], nodes[4] });
            nodes[6].Children.AddRange(new[] { nodes[1], nodes[4] });

            // add the root node to the graph
            g.Nodes.Add(nodes[0]);

            return g;
        }
    }
}
