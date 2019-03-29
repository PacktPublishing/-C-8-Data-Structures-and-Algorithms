using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue);
            Console.WriteLine($"Peeking the first element: {queue.Peek()}");
            Console.WriteLine($"Enqueueing 30");
            queue.Enqueue(30);
            Console.WriteLine(queue);
            Console.WriteLine($"Dequeueing the first element: {queue.Dequeue()}");
            Console.WriteLine(queue);
            Console.WriteLine($"Enqueueing 40");
            queue.Enqueue(40);
            Console.WriteLine(queue);
            Console.WriteLine($"Dequeueing the first element: {queue.Dequeue()}");
            Console.WriteLine(queue);
            Console.WriteLine($"Dequeueing the first element: {queue.Dequeue()}");
            Console.WriteLine(queue);
        }
    }
}
