using CompositePatternInOneProject.DucksAndGooses;

namespace CompositePatternInOneProject;

public class DuckSimulator
{
    
    public void Simulate(AbstractDuckFactory duckFactory)
    {        
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        IQuackable gooseDuck = duckFactory.CreateGoose();
        Console.WriteLine("\nDuck Simulator: With Composite — Flocks");

        Flock flockOfDucks = new Flock();
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        Flock flockOfMallards = new Flock();
        IQuackable mallardOne = duckFactory.CreateMallardDuck();
        IQuackable mallardTwo = duckFactory.CreateMallardDuck();
        IQuackable mallardThree = duckFactory.CreateMallardDuck();
        IQuackable mallardFour = duckFactory.CreateMallardDuck();
        flockOfMallards.Add(mallardOne);
        flockOfMallards.Add(mallardTwo);
        flockOfMallards.Add(mallardThree);
        flockOfMallards.Add(mallardFour);
        flockOfDucks.Add(flockOfMallards);

        Quackologist quackologist = new Quackologist();
        flockOfDucks.RegisterObserver(quackologist);

        Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
        Simulate(flockOfDucks);

        Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
        Simulate(flockOfMallards);

        Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times");
    }

    private void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}
