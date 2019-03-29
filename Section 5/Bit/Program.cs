using System;
using System.Collections;

namespace Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new BitArray(new bool[] { true, false, true, false });

            Console.Write("Original:    ");
            a.PrintElements();

            Console.Write("Left shift:  ");
            a.LeftShift(1);
            a.PrintElements();

            Console.Write("Left shift:  ");
            a.LeftShift(1);
            a.PrintElements();

            Console.Write("Right shift: ");
            a.RightShift(1);
            a.PrintElements();

            Console.Write("Right shift: ");
            a.RightShift(1);
            a.PrintElements();

            Console.Write("Right shift: ");
            a.RightShift(1);
            a.PrintElements();

            Console.WriteLine("--------");
            a = new BitArray(new bool[] { true, false, true, false });
            Console.Write("Original:       ");
            a.PrintElements();

            Console.Write("Toggle 4th bit: ");
            a[3] = true;
            a.PrintElements();

            var b = new BitArray(new bool[] { true, false, true, false });
            Console.Write("XOR:            ");
            var c = a.Xor(b);
            c.PrintElements();
            Console.WriteLine("--------");
            Console.WriteLine($"The fourth bit of: 0101 is {GetBit(0b_0101, 3)}");
            Console.WriteLine($"The third bit of:  0101 is {GetBit(0b_0101, 2)}");

            int number = 0b_0101;
            Console.WriteLine("Enabling the second bit in:        0101 - " + 
                            $"{EnableBit(number, 1).AsBinary(4)}");
            Console.WriteLine("Disabling the third bit in:        0101 - " + 
                            $"{DisableBit(number, 2).AsBinary(4)}");
            Console.WriteLine("Setting the fourth bit as true in: 0101 - " +
                            $"{SetBit(number, 3, true).AsBinary(4)}");
        }


        static bool GetBit(int number, int bit)
        {
            int mask = 1 << bit;

            return (number & mask) != 0;
        }

        static int EnableBit(int number, int bit)
        {
            int mask = 1 << bit;

            return number | mask;
        }

        static int DisableBit(int number, int bit)
        {
            int mask = ~(1 << bit);

            return number & mask;
        }


        static int SetBit(int number, int bit, bool enabled)
        {
            int v = enabled ? 1 : 0;
            int mask = ~(1 << bit);

            return (number & mask) | (v << bit);
        }

    }
}
