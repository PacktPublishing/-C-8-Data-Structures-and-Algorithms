using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Value { get; set; }
    }

    public class Stack<T>
    {
        protected Node<T> Head { get; set; }

        public void Push(T value)
        {
            var valueNode = new Node<T> { Value = value, Next = null };
            if (null == Head)
            {
                Head = valueNode;
                return;
            }

            valueNode.Next = Head;
            Head = valueNode;
        }

        public T Pop()
        {
            if (null == Head) throw 
                new InvalidOperationException("The stack is empty!");

            var result = Head.Value;

            Head = Head.Next;

            return result;
        }

        public T Peek()
        {
            if (null == Head) throw
                new InvalidOperationException("The stack is empty!");

            return Head.Value;
        }

        public override string ToString()
        {            
            string result = "[";
            var node = Head;

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
}
