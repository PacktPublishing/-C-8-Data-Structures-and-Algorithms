using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollections
{
    public static class HashingTricks
    {
        public static void Demo()
        {
            Console.WriteLine("Reference types as keys");
            Console.WriteLine();
            var a = new HashSet<CustomClass>();

            var item = new CustomClass() { IntPart = 1, StringPart = "A" };
            var item2 = new CustomClass() { IntPart = 1, StringPart = "A" };
            a.Add(item);

            Console.WriteLine($"Item 1 hashcode: {item.GetHashCode()}");
            Console.WriteLine($"Item 2 hashcode: {item2.GetHashCode()}");

            Console.WriteLine($"Hash set contains the item 1: {a.Contains(item)}");
            Console.WriteLine($"Hash set contains the item 2: {a.Contains(item2)}");
            Console.WriteLine();
            Console.WriteLine("Value types as keys");
            Console.WriteLine();

            var b = new HashSet<CustomStruct>();

            var v = new CustomStruct() { StringPart = "A", IntPart = 1 };
            var v2 = new CustomStruct() { StringPart = "A", IntPart = 10 };

            Console.WriteLine($"Item 1 hashcode: {v.GetHashCode()}");
            Console.WriteLine($"Item 2 hashcode: {v2.GetHashCode()}"); 

            b.Add(v);
            Console.WriteLine($"Hash set contains the item 1: {b.Contains(v)}");
            Console.WriteLine($"Hash set contains the item 2: {b.Contains(v2)}");

            Console.WriteLine();
            Console.WriteLine("Hash code override can lead to errors");
            Console.WriteLine();
            var c = new HashSet<WrongHashcode>();
            var w = new WrongHashcode { IntPart = 1 };
            c.Add(w);
            Console.WriteLine($"Hash set contains the item: {c.Contains(w)}");
            w.IntPart = 10;
            Console.WriteLine($"Hash set contains the item: {c.Contains(w)}");
        }
    }
}
