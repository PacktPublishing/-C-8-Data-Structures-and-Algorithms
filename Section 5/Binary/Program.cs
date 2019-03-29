using System;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0b_1011;
            Console.WriteLine($"Int {a} is binary {a.AsBinary(4)}");

            a = 0b_0101;
            int b = 0b_1001;

            int c = a & b;
            Console.WriteLine($"{a.AsBinary(4)} & {b.AsBinary(4)} = {c.AsBinary(4)}");

            c = a | b;
            Console.WriteLine($"{a.AsBinary(4)} | {b.AsBinary(4)} = {c.AsBinary(4)}");

            c = a ^ b;
            Console.WriteLine($"{a.AsBinary(4)} ^ {b.AsBinary(4)} = {c.AsBinary(4)}");

            c = ~a;
            // c is 32-bit number, so all bits get toggled
            // let's get only last 4 bits
            string bits = c.AsBinary(4);
            bits = bits.Substring(bits.Length - 4, 4);
            Console.WriteLine($"~{a.AsBinary(4)} = {bits}");
            Console.WriteLine("--------");
            for (sbyte i = 3; i > -4; i--)
            {
                Console.WriteLine($"Int {i} is binary {i.AsBinary()}");
            }
            Console.WriteLine("--------");
            c = 1;
            Console.WriteLine($"Int {c} is binary {c.AsBinary(8)}");
            // make a number negative
            c = ~c + 1;
            Console.WriteLine($"Int {c} is binary {c.AsBinary(8).Substring(0,8)}");
            Console.WriteLine("-------- Shift Left --------");

            TestShiftLeft();
            Console.WriteLine("-------- Shift Right -------");
            TestShiftRight();
            Console.WriteLine("-------- Shift Right Signed ");
            TestShiftRightSigned();
        }

        // the complicated code because int is 32 bit value
        // and i want to slice the first four bits, since 
        // remaining bits does not matter

        static void TestShiftRightSigned()
        {
            //isnt possible to use 0b_1001_ since its going to be uint
            int i = 0b_0101_0000_0000_0000_0000_0000_0000_0000;
            i =  i << 1;
            string fb = i.AsBinary(32).Substring(0, 4);
            int f = i >> 1;
            string ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i >> 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i >> 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");

        }

        static void TestShiftRight()
        {
            int i = 0b_0101_0000_0000_0000_0000_0000_0000_0000;
            string fb = i.AsBinary(32).Substring(0, 4);
            int f = i >> 1;
            string ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i >> 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i >> 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} >> 1 is binary {ffb}");
        }

        static void TestShiftLeft()
        {
            int i = 0b_0101_0000_0000_0000_0000_0000_0000_0000;
            string fb = i.AsBinary(32).Substring(0, 4);
            int f = i << 1;
            string ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} << 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i << 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} << 1 is binary {ffb}");
            i = f;
            fb = ffb;
            f = i << 1;
            ffb = f.AsBinary(32).Substring(0, 4);
            Console.WriteLine($"{fb} << 1 is binary {ffb}");
        }

    }
}
