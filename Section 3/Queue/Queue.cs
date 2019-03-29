using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }

        public T Value { get; set; }
    }   
    public class Queue<T>
    {
        protected Node<T> Head { get; set; }
        protected Node<T> Tail { get; set; }

        public void Enqueue(T value)
        {
            var valueNode = new Node<T> { Value = value, Next = null };
            if (null == Tail)
            {
                Head = valueNode;
                Tail = Head;
                return;
            }

            Tail.Next = valueNode;
            Tail = valueNode;
        }

        public T Dequeue()
        {
            if (null == Head) throw
                new InvalidOperationException("The queue is empty!");

            var result = Head.Value;

            Head = Head.Next;

            return result;
        }

        public T Peek()
        {
            if (null == Head) throw
                new InvalidOperationException("The queue is empty!");

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
