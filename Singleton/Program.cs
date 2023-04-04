using Singleton;

Singleton.Singleton singleton = Singleton.Singleton.getInstance();

ChocoFactory chocoFactory = ChocoFactory.GetChocoFactory();

chocoFactory.fill();

chocoFactory.boil();

chocoFactory.drain();

ChocoFactory secondChocoFactory = ChocoFactory.GetChocoFactory();

Console.WriteLine("Hello, World!");
