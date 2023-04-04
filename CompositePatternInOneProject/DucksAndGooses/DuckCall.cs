namespace CompositePatternInOneProject.DucksAndGooses;

public class DuckCall : IQuackable
{
    private Observable _observable;

    public DuckCall()
    {
        _observable = new Observable(this);
    }

    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void Quack()
    {
        Console.WriteLine("Kwack");
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
