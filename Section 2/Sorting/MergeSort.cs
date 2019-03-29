using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class MergeSortExtensions
    {
        public static int[] MergeSort(this int[] sourceArray)
        {
            // to not modify the source array;
            int[] array = sourceArray.CreateCopy();
            int[] temp = new int[array.Length];

            MergeSort(array, temp, 0, array.Length - 1);

            return array;
        }

        static void MergeSort(int[] array, int[] temp, int left, int right)
        {
            if (left >= right) return;

            int middle = (left + right) / 2;

            MergeSort(array, temp, left, middle);
            MergeSort(array, temp, middle + 1, right);

            Merge(array, temp, left, right);
        }

        static void Merge(
            int[] array, int[] temp, int leftHalfStart, int rightHalfEnd)
        {
            int leftHalfEnd = (leftHalfStart + rightHalfEnd) / 2;
            int rightHalfStart = leftHalfEnd + 1;
            int size = rightHalfEnd - leftHalfStart + 1;

            int left = leftHalfStart;
            int right = rightHalfStart;
            int i = leftHalfStart;

            while (left <= leftHalfEnd && right <= rightHalfEnd)
            {
                if(array[left] <= array[right])
                {
                    temp[i] = array[left];
                    left++;
                }
                else
                {
                    temp[i] = array[right];
                    right++;
                }
                i++;
            }

            // copying the left side elements remaining
            Array.Copy(array, left, temp, i, leftHalfEnd - left + 1);
            // copying the right side elements remaining
            Array.Copy(array, right, temp, i, rightHalfEnd - right + 1);
            // copying the sorted elements back to the source array
            Array.Copy(temp, leftHalfStart, array, leftHalfStart, size);
        }
    }
}
