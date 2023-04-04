namespace CompositePatternInOneProject.DucksAndGooses
{
    public interface IQuackable : IQuackObservable
    {        
        public void Quack();
    }
}
