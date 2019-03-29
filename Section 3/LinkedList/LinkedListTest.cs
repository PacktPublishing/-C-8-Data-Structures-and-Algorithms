using System;

namespace LinkedList
{
    class LinkedListTest
    {
        public static void Test()
        {
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(5);
            list.Add(12);
            list.Add(15);

            Console.WriteLine(list);

            var (previous, node) = list.FindFirst(5);

            Console.WriteLine(node.Value);
            Console.WriteLine(node.Next.Value);

            list.DeleteAfter(previous);

            Console.WriteLine(list);

            list.AddAfter(previous, 10);

            Console.WriteLine(list);
        }
    }
}