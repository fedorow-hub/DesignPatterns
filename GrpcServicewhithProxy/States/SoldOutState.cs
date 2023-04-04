namespace GrpcServicewhithProxy
{
    public class SoldOutState : IState
    {
        GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("There isn't a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You isn't insert a quater");
        }

        public void TurnCrank()
        {
            Console.WriteLine("There isn't a gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("There isn't a gumball");
        }

        public override string ToString()
        {
            return "SoldOutState";
        }

        public void Refill()
        {            
            gumballMachine.SetState(gumballMachine.NoQuarterState);            
        }
    }
}
