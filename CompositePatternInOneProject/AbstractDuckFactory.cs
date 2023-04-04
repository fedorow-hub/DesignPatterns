using CompositePatternInOneProject.DucksAndGooses;

namespace CompositePatternInOneProject;

/// <summary>
/// Используется для паттерна Абстрактная фабрика
/// </summary>
public abstract class AbstractDuckFactory
{
    public abstract IQuackable CreateMallardDuck();
    public abstract IQuackable CreateRedheadDuck();
    public abstract IQuackable CreateDuckCall();
    public abstract IQuackable CreateRubberDuck();
    public abstract IQuackable CreateGoose();
}
