using System;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new Hashtable<int>(4);

            Console.WriteLine(h.GetBucketByKey("One"));
            Console.WriteLine(h.GetBucketByKey("Two"));
            Console.WriteLine(h.GetBucketByKey("Three"));

            h.Add("One", 1);
            h.Add("Two", 2);
            h.Add("Three", 3);

            Console.WriteLine(h.Get("One"));
            Console.WriteLine(h.Get("Two"));
            Console.WriteLine(h.Get("Three"));

            try
            {
                Console.WriteLine(h.Get("Four"));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(h.Remove("Three"));
            Console.WriteLine(h.Remove("Three"));
            Console.WriteLine(h.Remove("Two"));
            Console.WriteLine(h.Remove("Two"));


        }
    }
}
