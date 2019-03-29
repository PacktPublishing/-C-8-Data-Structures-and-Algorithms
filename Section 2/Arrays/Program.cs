using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayTest();
        }

        static void ArrayTest()
        {
            int[] array = new int[] { 1, 2, 3 };

            array.PrintElements();
            array[1] = 10;
            array.PrintElements();

            try
            {
                array[3] = 10;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // A multi-dimensional array. 2D space, 
            // a table in this case
            int[,] a = {
                { 1, 2, 3},
                { 4, 5, 6}
            };
            Console.WriteLine(
                $"A multi-dimensional array length: {a.Length}");

            // A jagged array. It's an array of arrays, so you
            // need to initialize nested arrays afterwards
            int[][] b =  {
                new int[] { 1, 2, 3 },
                new int[] { 10, 20, 30, 40, 50 },
                new int[] { 5, 6 },
            };

            Console.WriteLine($"The jagged array length: {b.Length}");
            Console.WriteLine($"The nested array length: {b[1].Length}");

            // an element in the first row, first column
            a[0, 0] = 10;

            // The first element's first element
            b[0][0] = 10;

            int[][][] c = new int[2][][];
            // int[2][2][2] or int[2][2][] is not possible - 
            // you can initialize only the first rank
            // Also, nested arrays are not initialized, 
            // c[0].Length will give null reference exception
        }

        static void ArrayListTest()
        {
            ArrayList<int> customArrayList = 
                new ArrayList<int>();
            customArrayList.Add(4);
            customArrayList.Add(5);
            customArrayList.Add(6);
            customArrayList.PrintElements();

            try
            {
                customArrayList[3] = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            customArrayList.Add(20);
            customArrayList.PrintElements();
            customArrayList.Insert(2, 200);
            customArrayList.PrintElements();
        }

        static void LibraryListTest()
        {

            List<int> arrayList = new List<int> { 4, 5, 6 };
            arrayList.PrintElements();

            try
            {
                arrayList[3] = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            arrayList.Add(20);
            arrayList.PrintElements();
            arrayList.Insert(2, 200);
            arrayList.PrintElements();
        }
    }
}
