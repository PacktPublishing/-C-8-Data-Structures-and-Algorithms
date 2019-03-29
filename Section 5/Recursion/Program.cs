using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintElements("Fibonacci Recursive  ", FibonacciRecursive);
            PrintElements("Fibonacci Memoization", FibonacciMemoization);
            PrintElements("Fibonacci Iterative  ", FibonacciIterative);
        }

        static int FibonacciRecursive(int n)
        {
            if (n == 1 || n == 2) return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciMemoization(int n)
        {
            int[] memo = new int[n];
            return Fib(n);

            int Fib(int i)  
            {
                if (i == 1 || i == 2) return 1;

                if (memo[i - 1] > 0) return memo[i - 1];

                return Fib(i - 1) + Fib(i - 2);
            }
        }

        static int FibonacciIterative(int n)
        {
            int fib = 1;
            int previousFib = 1;
            for(int i = 3; i <= n; i++)
            {
                int temp = fib;
                fib += previousFib;
                previousFib = temp;
            }

            return fib;
        }

        static void PrintElements(string name, Func<int, int> fib)
        {
            Console.Write($"{name}: [");
            for (int i = 1; i <= 10; i++)
            {
                if (i > 1) Console.Write(", ");
                Console.Write(fib(i));
            }
            Console.WriteLine("]");
        }
    }
}
