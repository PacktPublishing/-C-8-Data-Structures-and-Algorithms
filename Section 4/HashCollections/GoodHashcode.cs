using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollections
{
    public class GoodHashcode
    {
        public int IntPart { get; }

        public GoodHashcode(int value)
        {
            IntPart = value;
        }

        public override int GetHashCode()
        {
            return IntPart;
        }
    }
}
