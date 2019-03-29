using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = GenerateRandomArray(10);
            Console.WriteLine("The original array: ");
            arrayToSort.PrintElements();

            Console.WriteLine("-----------------------");
            Console.Write("Selection sort: ");
            arrayToSort.SelectionSort().PrintElements();
            Console.Write("Bubble sort:    ");
            arrayToSort.BubbleSort().PrintElements();
            Console.Write("Merge sort:     ");
            arrayToSort.MergeSort().PrintElements();
            Console.Write("Quick sort:     ");
            arrayToSort.QuickSort().PrintElements();
        }

        static int[] GenerateRandomArray(int size)
        {
            var rnd = new Random();
            int[] result = new int[size];

            for(int i = 0; i < size; i++)
            {
                result[i] = rnd.Next(0, 100);
            }

            return result;
        }

       
    }
}
