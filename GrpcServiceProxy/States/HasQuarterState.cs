namespace GrpcServiceProxy
{
    public class HasQuarterState : IState
    {
        Random random= new Random();
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You already insert a quater");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You return a quater");
            gumballMachine.SetState(gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = random.Next(10);            
            if (winner == 1 && gumballMachine.Count > 1) 
            {
                gumballMachine.SetState(gumballMachine.WinnerState);
                return;
            }
            gumballMachine.SetState(gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "HasQuarterState";
        }

        public void Refill()
        {
            Console.WriteLine("There is many of gumballs");
        }
    }
}
