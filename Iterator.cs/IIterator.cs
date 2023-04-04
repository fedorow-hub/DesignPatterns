namespace Iterator.cs
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
