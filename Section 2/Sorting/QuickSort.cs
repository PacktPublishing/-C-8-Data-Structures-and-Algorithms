using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class QuickSortExtensions
    {
        public static int[] QuickSort(this int[] sourceArray)
        {
            int[] array = sourceArray.CreateCopy();

            QuickSort(array, 0, array.Length - 1);

            return array;
        }

        static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            // ideally the pivot value should be a median value
            // here we use a random pivot
            var r = new Random();
            int pivot = array[r.Next(left, right)];

            int partition = Partition(array, left, right, pivot);
            QuickSort(array, left, partition - 1);
            QuickSort(array, partition, right);
        }

        static int Partition(int[] array, int leftStart, int rightEnd, int pivot)
        {
            int left = leftStart;
            int right = rightEnd;

            while (left <= right)
            {
                while(array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if(left <= right)
                {
                    array.Swap(left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}
