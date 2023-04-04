using GrpcServicewhithProxy;

namespace GrpcClientWithProxy
{
    public class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + machine.Location);
            Console.WriteLine("Current inventory: " + machine.Count + " gumballs");
            Console.WriteLine("Current state: " + machine.State);
        }
    }
}
