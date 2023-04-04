namespace Facade.Components
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper is on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper is off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn popper is pop");
        }

        public override string ToString()
        {
            return "Popcorn popper";
        }
    }
}
