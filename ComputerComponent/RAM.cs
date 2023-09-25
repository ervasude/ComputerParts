using System;
using assignment1.ValueObjects;

namespace assignment1.ComputerComponent
{
    internal class RAM
	{
        public string Brand { get; set; }

        public Capacity Capacity { get; set; }

        public RAM() { }

        public RAM(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }
    }
}

