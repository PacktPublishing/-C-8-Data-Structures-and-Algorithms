using System;
using System.Collections.Generic;
using System.Text;

namespace Heaps
{
    public static class Extensions
    {
        public static void Swap<T>(this T[] array, int i, int j)
        {
            if (i < 0 || i >= array.Length) throw new ArgumentOutOfRangeException(nameof(i));
            if (j < 0 || j >= array.Length) throw new ArgumentOutOfRangeException(nameof(j));


            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void Swap<T>(this List<T> array, int i, int j)
        {
            if (i < 0 || i >= array.Count) throw new ArgumentOutOfRangeException(nameof(i));
            if (j < 0 || j >= array.Count) throw new ArgumentOutOfRangeException(nameof(j));


            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void PrintElements<T>(this List<T> array)
        {
            if (null == array || array.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.Write("[");
            for (int i = 0; i < array.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{array[i]}");
                }
                else
                {
                    Console.Write($", {array[i]}");
                }
            }
            Console.WriteLine("]");
        }
    }
}
