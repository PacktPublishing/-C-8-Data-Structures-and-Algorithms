using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = 
                new int[] { -34, -21, -18, -12, -3, -1, 0, 3, 8, 12, 23 };

            Console.Write($"Test array: ");
            testArray.PrintElements();

            int testItem = -12;
            PrintSearchInformation(testItem, testArray);

            testItem = 0;
            PrintSearchInformation(testItem, testArray);

            testItem = 23;
            PrintSearchInformation(testItem, testArray);

            testItem = 2;
            PrintSearchInformation(testItem, testArray);
        }

        static void PrintSearchInformation(int testItem, int[] testArray)
        {
            Console.WriteLine($"Searching for {testItem}: " +
                $"Linear {testArray.LinearSearch(testItem)}, " +
                $"Binary {testArray.BinarySearch(testItem)}, " +
                $"Binary iterative {testArray.BinarySearchIterative(testItem)}");
        }
    }
}
