using CompositePatternInOneProject;

DuckSimulator simulator= new DuckSimulator();
AbstractDuckFactory duckFactory = new CountingDuckFactory();

simulator.Simulate(duckFactory);

Console.ReadLine();
