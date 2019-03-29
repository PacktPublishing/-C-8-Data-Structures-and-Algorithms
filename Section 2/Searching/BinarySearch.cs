using System;

namespace Searching
{
    public static class BinarySearchExtension
    {
        public static int BinarySearch(this int[] array, int value)
        {
            return BinarySearch(array, 0, array.Length - 1, value);
        }

        private static int BinarySearch(int[] array, int start,int end, int value)
        {
            if (start > end) return -1;

            int middleElement = (end + start) / 2;

            if(value < array[middleElement])
            {
                return BinarySearch(array, start, middleElement - 1, value);
            }
            else if(value > array[middleElement])
            {
                return BinarySearch(array, middleElement + 1, end, value);
            }
            else
            {
                return middleElement;
            }
        }
    }
}