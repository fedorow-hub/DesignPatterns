namespace Adapter
{
    public class MallardDuck : IDuck
    {
        public void fly()
        {
            Console.WriteLine("Quack");
        }

        public void quack()
        {
            Console.WriteLine("I’m flying");
        }
    }
}
