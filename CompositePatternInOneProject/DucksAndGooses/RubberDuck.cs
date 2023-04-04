namespace CompositePatternInOneProject.DucksAndGooses;

public class RubberDuck : IQuackable
{
    private Observable _observable;

    public RubberDuck()
    {
        _observable = new Observable(this);
    }
    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void Quack()
    {
        Console.WriteLine("Squeak");
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observable.RegisterObserver(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observable.RemoveObserver(observer);
    }    
}
