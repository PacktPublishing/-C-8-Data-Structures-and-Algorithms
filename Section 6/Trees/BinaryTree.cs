using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Node
    {
        public Node(int value, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public int Value { get; }

        public Node Left { get; }

        public Node Right { get; }
    }
}
