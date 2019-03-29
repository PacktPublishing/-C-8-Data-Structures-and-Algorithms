using System;
using System.Collections.Generic;
using System.Text;

namespace Binary
{
    public static class Extensions
    {
        public static string AsBinary(this int i, int padding)
        {
            return Convert.ToString(i, 2).PadLeft(padding, '0');
        }

        public static string AsBinary(this sbyte b)
        {
            var sb = new StringBuilder(8);
            int[] bits = new int[8];

            for (int i = 0; i < bits.Length; i++)
            {
                bits[bits.Length - 1 - i] = ((b & (1 << i)) != 0) ? 1 : 0;
            }

            foreach (int num in bits) sb.Append(num);

            return sb.ToString().PadLeft(8, '0') ;
        }
    }
}
