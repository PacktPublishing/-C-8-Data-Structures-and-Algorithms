using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello, World!";

            // string is an array of chars
            for(int i = 0; i < message.Length; i ++)
            {
                if(i > 6 && i < 12)
                {
                    Console.Write(message[i]);
                }
            }
            Console.WriteLine();
            
            // but we cannot change strings in C# in this way
            // message[7] = 'w';

            message = "The number to be parsed is: 123";
            // this creates a new string
            // Substring, Trim, IsNullOrWhitespace will also produce more strings
            string num = message.Substring(message.IndexOf(':') + 2);
            int.TryParse(num, out var a);
            Console.WriteLine(a);

            // this does not create string copies
            ReadOnlySpan<char> msgSpan = message;
            ReadOnlySpan<char> numSpan = msgSpan.Slice(msgSpan.IndexOf(':') + 2);
            int.TryParse(numSpan, out var b);
            Console.WriteLine(b);

            string firstString = "Test string";
            string secondString = "Test string";

            // Prints out true, because of sting intern pool
            Console.WriteLine(object.ReferenceEquals(firstString, secondString));

            // The following is not possible, the api gives 
            // only ReadOnlySpan and ReadOnlyMemory
            // Span<char> span = firstString.AsSpan();
            // Memory<char> mem = firstString.AsMemory();

            // Only use this approach when you know what you're doing 
            // and aware of the consequences
            Memory<char> mem = MemoryMarshal.AsMemory(firstString.AsMemory());
            mem.Span[5] = 'Z';

            Console.WriteLine(firstString);
            Console.WriteLine(secondString);

            // Use stringbuilder or memory buffers if you need 
            // to concatenate lots of strings

            var sb = new StringBuilder();
            foreach(int i in Enumerable.Range(1,10))
            {
                sb.Append(i.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
