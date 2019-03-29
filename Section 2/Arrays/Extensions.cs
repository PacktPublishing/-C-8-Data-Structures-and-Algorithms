using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
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

        public static void PrintElements<T>(this List<T> arrayList)
        {
            if (null == arrayList || arrayList.Count == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.Write("[");
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{arrayList[i]}");
                }
                else
                {
                    Console.Write($", {arrayList[i]}");
                }
            }
            Console.WriteLine("]");
        }

        public static void PrintElements<T>(this ArrayList<T> arrayList)
        {
            if (null == arrayList || arrayList.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            Console.Write("[");
            for (int i = 0; i < arrayList.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{arrayList[i]}");
                }
                else
                {
                    Console.Write($", {arrayList[i]}");
                }
            }
            Console.WriteLine($"], storageSize: {arrayList.StorageLength}");
        }
    }
}
