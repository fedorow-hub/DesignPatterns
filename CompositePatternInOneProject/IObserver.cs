namespace CompositePatternInOneProject;

public interface IObserver
{
    public void Update(IQuackObservable duck);
}
