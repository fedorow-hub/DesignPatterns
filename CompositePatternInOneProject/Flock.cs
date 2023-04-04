using CompositePatternInOneProject.DucksAndGooses;

namespace CompositePatternInOneProject;

public class Flock : IQuackable
{
    List<IQuackable> quackers = new List<IQuackable>();

    private Observable _observable;

    public Flock()
    {
        _observable = new Observable(this);
    }

    public void Add(IQuackable quacker)
    {
        quackers.Add(quacker);
    }

    public void NotifyObservers()
    {
        _observable.NotifyObservers();
    }

    public void Quack()
    {
        //Здесь используется паттерн Итератор
        IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
        while (iterator.MoveNext())
        {
            IQuackable quacker = iterator.Current;
            quacker.Quack();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        IEnumerator<IQuackable> iterator = quackers.GetEnumerator();
        while (iterator.MoveNext())
        {
            IQuackable quacker = iterator.Current;
            quacker.RegisterObserver(observer);
        }
        
    }

    public void RemoveObserver(IObserver observer)
    {
        _observable.RemoveObserver(observer);
    }

}
