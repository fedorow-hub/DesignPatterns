namespace CompositePatternInOneProject.DucksAndGooses;

public class RedheadDuck : IQuackable
{
    private Observable _observable;

    public RedheadDuck()
    {
        _observable = new Observable(this);
    }
    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
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
