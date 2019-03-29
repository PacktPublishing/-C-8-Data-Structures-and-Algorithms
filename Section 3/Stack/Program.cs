using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack);
            Console.WriteLine($"Peeking the top element: {stack.Peek()}");
            Console.WriteLine(stack);
            stack.Push(30);
            Console.WriteLine("Pushing 30 on the stack");
            Console.WriteLine(stack);
            Console.WriteLine($"Popping the top element: {stack.Pop()}");
            Console.WriteLine(stack);
            stack.Push(40);
            Console.WriteLine("Pushing 40 on the stack");
            Console.WriteLine(stack);
            Console.WriteLine($"Popping the top element: {stack.Pop()}");
            Console.WriteLine(stack);
            Console.WriteLine($"Popping the top element: {stack.Pop()}");
            Console.WriteLine(stack);
        }
    }
}
