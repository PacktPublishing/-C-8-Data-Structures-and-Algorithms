using System;
using System.Collections.Generic;
using System.Text;

namespace HashCollections
{
    public class WrongHashcode
    {
        public int IntPart { get; set; }

        public override int GetHashCode()
        {
            return IntPart;
        }
    }
}
