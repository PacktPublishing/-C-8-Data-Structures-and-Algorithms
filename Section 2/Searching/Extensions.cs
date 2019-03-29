using System;

namespace Searching
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
    }
}
