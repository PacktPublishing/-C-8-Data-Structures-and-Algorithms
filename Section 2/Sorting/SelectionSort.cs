using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class SelectionSortExtensions
    {
        public static int[] SelectionSort(this int[] sourceArray)
        {
            // to not modify the source array;
            int[] array = sourceArray.CreateCopy();

            for(int i = 0; i < array.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min]) min = j;
                }

                if (min == i) continue;

                array.Swap(i, min);
            }

            return array;
        }
    }
}
