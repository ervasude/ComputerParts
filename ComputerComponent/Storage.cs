using System;
using assignment1.ValueObjects;

namespace assignment1.ComputerComponent
{
    internal class Storage
    {
        public string Brand { get; set; }

        public Capacity Capacity { get; set; }

        public Storage() { }

        public Storage(string brand, Capacity Capacity)
        {
            Brand = brand;

        }
    }
}

