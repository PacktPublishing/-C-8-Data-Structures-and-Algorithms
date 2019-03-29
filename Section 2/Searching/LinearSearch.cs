using System;

namespace Searching
{
    public static class LinearSearchExtension
    {
        public static int LinearSearch(this int[] array, int value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) return i;
            }

            return -1;
        }
    }
}