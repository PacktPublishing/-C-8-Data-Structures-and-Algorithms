using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public static class Extensions
    {
        public static void PrintElements<T>(this T[] array)
        {
            if (null == array || array.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
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

        public static void Swap<T>(this T[] array, int i, int j)
        {
            if (i < 0 || i >= array.Length) throw new ArgumentOutOfRangeException(nameof(i));
            if (j < 0 || j >= array.Length) throw new ArgumentOutOfRangeException(nameof(j));


            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static T[] CreateCopy<T>(this T[] sourceArray)
        {
            T[] array = new T[sourceArray.Length];
            sourceArray.CopyTo(array, 0);

            return array;
        }
     }
}
