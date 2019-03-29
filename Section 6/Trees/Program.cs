using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = CreateTestTree();

            VisitNodePreOrder(tree);
            Console.WriteLine("--------");
            VisitNodePostOrder(tree);
            Console.WriteLine("--------");
            VisitNodeInOrder(tree);

            Console.WriteLine("--------");
            Console.Write("Searching for value 50: ");
            Console.WriteLine(Search(tree, 50) == null ? "Not Found!" : "Found!");
            Console.Write("Searching for value 55: ");
            Console.WriteLine(Search(tree, 55) == null ? "Not Found!" : "Found!");
        }

        static Node CreateTestTree()
        {
            return new Node(60,
                    new Node(30,
                        new Node(10,
                            new Node(1),
                            new Node(20)),
                        new Node(40,
                            new Node(35),
                            new Node(50))),
                    new Node(100,
                        new Node(80,
                            new Node(70),
                            new Node(90)),
                        new Node(120,
                                left: new Node(110))
                        )
                    );
        }

        static Node Search(Node tree, int value)
        {
            if (null == tree) return null;
            if (value == tree.Value) return tree;

            if (value <= tree.Value) return Search(tree.Left, value);

            return Search(tree.Right, value);
        }

        static void VisitNodePreOrder(Node node, int level = 0)
        {
            if (null == node) return;

            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");

            VisitNodePreOrder(node.Left, level + 1);
            VisitNodePreOrder(node.Right, level + 1);
        }

        static void VisitNodePostOrder(Node node, int level = 0)
        {
            if (null == node) return;

            VisitNodePostOrder(node.Left, level + 1);
            VisitNodePostOrder(node.Right, level + 1);

            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");
        }

        static void VisitNodeInOrder(Node node, int level = 0)
        {
            if (null == node) return;

            VisitNodeInOrder(node.Left, level + 1);

            string separator = new string('-', level);
            Console.WriteLine($"{separator}{node.Value}");

            VisitNodeInOrder(node.Right, level + 1);
        }
    }
}
