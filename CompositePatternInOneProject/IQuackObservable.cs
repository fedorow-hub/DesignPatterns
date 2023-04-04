namespace CompositePatternInOneProject;

public interface IQuackObservable
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}
