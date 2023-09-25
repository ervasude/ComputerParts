using System;
using assignment1.Enums;

namespace assignment1.ValueObjects
{
	
        public class Capacity
        {
            public Capacity(int size, SizeType sizeType)
            {
                Size = size;
                SizeType = sizeType;
            }

            public int Size { get; set; }

            public SizeType SizeType { get; set; }

        }
    
}

