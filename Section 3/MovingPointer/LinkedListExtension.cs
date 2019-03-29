using System;

namespace MovingPointer
{
    public static class LinkedListExtension
    {
        public static Node<T> SplitIntoHalves<T>(
            this LinkedList<T> list)
        {
            var fast = list.Root;
            var slow = list.Root;

            while (null != fast.Next && null != fast.Next.Next)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            } 

            return slow;
        }

        public static (Node<T> previous, Node<T> cycle) GetCycleNodes<T>(
            this LinkedList<T> list)
        {
            Node<T> node = GetNodeInsideLoop(list);

            if (null == node) return (null, null);

            //get the size of the loop
            int size = 1;
            Node<T> slidingNode = node;

            while(slidingNode.Next != node)
            {
                slidingNode = slidingNode.Next;
                size++;
            }

            Node<T> first = list.Root;
            Node<T> previous = list.Root;
            Node<T> second = list.Root;

            for(int i = 0; i < size; i++)
            {
                if (i != 0) previous = previous.Next;
                second = second.Next;
            }            

            while(first != second)
            {
                first = first.Next;
                second = second.Next;
                previous = previous.Next;
            }

            return (previous, second);
        }

        private static Node<T> GetNodeInsideLoop<T>(
            this LinkedList<T> list)
        {
            var fast = list.Root;
            var slow = list.Root;

            while (null != fast.Next && null != fast.Next.Next)
            {
                fast = fast.Next.Next;

                slow = slow.Next;
                if (fast == slow) return slow;
            }

            return null;
        }
      
        public static bool HasCycle<T>(this LinkedList<T> list)
        {
            var node = GetNodeInsideLoop(list);
            return null != node;
        }
    }
}
