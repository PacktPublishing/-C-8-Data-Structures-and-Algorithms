using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bit
{
    static class Extensions
    {
        public static void PrintElements(this BitArray bits)
        {
            Console.Write("[");
            for(int i = bits.Length - 1; i >=0 ; i--)
            {
                if (i < bits.Length - 1) Console.Write(", ");

                Console.Write(bits[i] ? 1 : 0);
            }
            Console.WriteLine("]");
        }

        public static string AsBinary(this int i, int padding)
        {
            return Convert.ToString(i, 2).PadLeft(padding, '0');
        }
    }
}
