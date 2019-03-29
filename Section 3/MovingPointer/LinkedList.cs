using System;

namespace MovingPointer
{
    public class LinkedList<T>
    {
        public Node<T> Root { get; private set; }

        public (Node<T> previous, Node<T> found) FindFirst(T value)
        {
            Node<T> previous = null;
            Node<T> current = Root;

            if (null == current) return (null, null);
            if (current.Value.Equals(value)) return (null, Root);

            do
            {
                previous = current;
                current = current.Next;

                if (current.Value.Equals(value)) return (previous, current);

            } while (null != current.Next);

            return (null, null);
        }

        public Node<T> AddAfter(Node<T> node, T value)
        {
            var valueNode = new Node<T>() { Next = node.Next, Value = value };
            node.Next = valueNode;

            return valueNode;
        }

        public Node<T> Add(T value)
        {
            var valueNode = new Node<T>() { Value = value, Next = null };

            if (null == Root) Root = valueNode;

            else
            {
                var node = Root;
                while (null != node.Next)
                {
                    node = node.Next;
                }

                node.Next = valueNode;
            }
            return valueNode;
        }

        public Node<T> AddNode(Node<T> valueNode)
        {
            if (null == Root) Root = valueNode;

            else
            {
                var node = Root;
                while (null != node.Next)
                {
                    node = node.Next;
                }

                node.Next = valueNode;
            }
            return valueNode;
        }

        public bool DeleteAfter(Node<T> node)
        {
            var nextNode = node.Next;
            if (null == nextNode) return false; // nothing to delete

            node.Next = nextNode.Next;
            return true;
        }

        public override string ToString()
        {
            if (this.HasCycle()) return "List with cycle";

            string result = "[";
            var node = Root;

            while (node != null)
            {
                result += node.Value;
                node = node.Next;

                if (null != node) result += ",";
            }

            result += "]";

            return result;
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Value { get; set; }
    }
}
