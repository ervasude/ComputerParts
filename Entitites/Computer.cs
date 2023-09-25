using System;
using assignment1.ComputerComponent;

namespace assignment1.Entitites
{
    internal class Computer
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }


        public string CPU { get; set; }


        public Storage Storage { get; set; }


        public RAM RAM { get; set; }



        public Computer()
        {
            Random random = new Random();
            Id = random.Next(10000, int.MaxValue);
        }

        public Computer(string brand, string model) : this()
        {

            Brand = brand.ToUpper();
            Model = model;
        }

        public Computer(string brand, string model, string cPU, RAM RAM, Storage storage) : this(brand, model)
        {
            CPU = cPU;
            this.RAM = RAM;//Assignment made to same variable so use "this" to fix it
            Storage = storage;
        }
    }
}

