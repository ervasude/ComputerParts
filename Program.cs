
using assignment1.ComputerComponent;
using assignment1.Entitites;
using assignment1.Enums;
using assignment1.ValueObjects;

Console.WriteLine();

Storage storage1 = new Storage("WD Blue", new Capacity(1, SizeType.TB));

RAM memory1 = new RAM("Corsair", new Capacity(16, SizeType.GB));
RAM memory2 = new RAM("Corsair", new Capacity(8, SizeType.GB));

Computer computer1 = new Computer("Apple", "MAcbook Pro", "Intel i7", memory1, storage1);
Computer computer2 = new Computer("Apple", "MAcbook Air", "Intel i5", memory2, storage1);
