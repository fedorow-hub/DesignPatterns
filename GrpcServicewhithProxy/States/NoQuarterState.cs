namespace GrpcServicewhithProxy
{
    public class NoQuarterState : IState
    {
        GumballMachine gumballMachine;
                
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.SetState(gumballMachine.HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't insert a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there isn't a quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You have to pay first");
        }

        public override string ToString()
        {
            return "NoQuarterState";
        }

        public void Refill()
        {
            Console.WriteLine("There is many of gumballs");
        }
    }
}
