using System;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = new MinHeap(30);
            h.Add(50);
            h.Add(20);
            h.Add(28);
            h.Add(31);
            h.Add(29);

            h.PrintElements();

            var m = new MaxHeap(30);

            m.Add(50);
            m.Add(20);
            m.Add(28);
            m.Add(31);
            m.Add(29);

            m.PrintElements();

            h.Pop();
            h.PrintElements();

            m.Pop();
            m.PrintElements();
        }
    }
}
