using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollections
{
    public static class HashCollections
    {
        public static void DictionaryDemo()
        {
            var dict = new Dictionary<string, int>();

            dict.Add("One", 1);
            dict["Two"] = 2;
            dict["Three"] = 3;

            Console.WriteLine(dict["One"]);
            Console.WriteLine(dict["Two"]);
            Console.WriteLine(dict["Three"]);
            try
            {
                Console.WriteLine(dict["Four"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int result = -1;
            bool succeeded = dict.TryGetValue("Four", out result);
            Console.WriteLine($"Operation succeeded: {succeeded}, result: {result}");
            succeeded = dict.TryGetValue("Three", out result);
            Console.WriteLine($"Operation succeeded: {succeeded}, result: {result}");

            foreach (var key in dict.Keys) Console.Write(key + " ");
            Console.WriteLine();
            foreach (var key in dict.Values) Console.Write(key + " ");
        }

        public static void HashsetDemo()
        {
            var h1 = new HashSet<int>() { 1, 2, 3 };
            var h2 = new HashSet<int>() { 1, 2, 3 };

            var h3 = new HashSet<int>() { 0, 1, 2, 3, 4 };

            Console.WriteLine($"{{1, 2, 3}} contains 4? : {h1.Contains(4)}");
            Console.WriteLine($"{{1, 2, 3, 4}} contains 4? : {h3.Contains(4)}");
            
            Console.WriteLine($"{{1, 2, 3}} equals {{1, 2, 3}}? : {h1.SetEquals(h2)}");

            // a set is a superset of itself
            // but not a proper superset
            Console.WriteLine($"Is {{0, 1, 2, 3, 4}} a proper superset of {{1,2,3}}? : " +
                h3.IsProperSupersetOf(h1));

            h3.IntersectWith(h1);
            Console.Write($"Intersection of {{0, 1, 2, 3, 4}} with {{1, 2, 3}} is : ");
            h3.PrintItems();

            h3 = new HashSet<int>() { 0, 1, 2, 3, 4 };
            h3.ExceptWith(h1);
            Console.Write($"{{0, 1, 2, 3, 4}} except of {{1, 2, 3}} is : ");
            h3.PrintItems();
        }

        public static void PrintItems<T>(this HashSet<T> set)
        {
            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
