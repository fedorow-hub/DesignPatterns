namespace CompositePatternInOneProject.DucksAndGooses;
/// <summary>
/// Используется для паттерна Декоратор
/// </summary>
public class QuackCounter : IQuackable
{
    private IQuackable _duck;

    private static int numberOfQuacks;

    public QuackCounter(IQuackable duck)
    {
        _duck = duck;        
    }

    public void Quack()
    {
        _duck.Quack();
        numberOfQuacks++;        
    }

    public static int GetQuacks()
    {
        return numberOfQuacks;
    }

    public void RegisterObserver(IObserver observer)
    {
        _duck.RegisterObserver(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _duck.RemoveObserver(observer);
    }

    public void NotifyObservers()
    {
        _duck.NotifyObservers();
    }

}
