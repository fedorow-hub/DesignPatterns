namespace CompositePatternInOneProject;

public class Observable : IQuackObservable
{
    List<IObserver> _observers = new List<IObserver>();
    private IQuackObservable _duck;
    public Observable(IQuackObservable duck)
    {
        _duck = duck;
    }

    public void NotifyObservers()
    {
        var iterator = _observers.GetEnumerator();
        while (iterator.MoveNext())
        {
            IObserver observer = iterator.Current;
            observer.Update(_duck);
        }
}

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

}
