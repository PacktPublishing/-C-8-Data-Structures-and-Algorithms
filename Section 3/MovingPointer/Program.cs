using System;

namespace MovingPointer
{
    class Program
    {
        static void Main(string[] args)
        {
            //SplitTest();
            //CyclesTest();
            GetCycleNodesTest();            
        }

        static void GetCycleNodesTest()
        {
            var list = new LinkedList<int>();

            list.Add(10);
            list.Add(20);
            Console.WriteLine(list);
            Console.WriteLine($"Has cycles: {list.HasCycle()}");
            Console.WriteLine("Adding cycle...");
            var cycleNode = new Node<int> { Value = 30, Next = list.Root };
            list.AddNode(cycleNode);
            Console.WriteLine($"Has cycles: {list.HasCycle()}");
            var (previous, loopNode) = list.GetCycleNodes();
            Console.WriteLine($"The node, that causes the loop: {previous.Value}");
            Console.WriteLine($"The node, that starts the loop: {loopNode.Value}");
            Console.WriteLine("Removing cycle...");
            previous.Next = null;
            Console.WriteLine($"Has cycles: {list.HasCycle()}");
            Console.WriteLine(list);
        }

        static void CyclesTest()
        {
            var list = new LinkedList<int>();

            list.Add(10);
            list.Add(20);
            var node = list.Add(30);           
            list.Add(40);
            list.Add(50);
            Console.WriteLine(list);
            Console.WriteLine($"Has cycles: {list.HasCycle()}");
            Console.WriteLine("Adding cycle");
            var cycleNode = new Node<int> { Value = 60, Next = node };
            list.AddNode(cycleNode);
            Console.WriteLine($"Has cycles: {list.HasCycle()}");
        }

        static void SplitTest()
        {
            var list = new LinkedList<int>();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Add(70);
            list.Add(80);

            Console.WriteLine(list);
            var node = list.SplitIntoHalves();
            Console.WriteLine(node.Value);

            list.Add(90);
            
            Console.WriteLine(list);
            node = list.SplitIntoHalves();
            Console.WriteLine(node.Value);
        }
    }
}
