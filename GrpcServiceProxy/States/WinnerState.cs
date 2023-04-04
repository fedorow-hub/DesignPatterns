namespace GrpcServiceProxy
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if(gumballMachine.Count == 0) 
            {
                gumballMachine.SetState(gumballMachine.SoldOutState);
            } 
            else
            {
                gumballMachine.ReleaseBall();
                Console.WriteLine("YOU’RE A WINNER! You got two gumballs for your quarter");
                if(gumballMachine.Count > 0)
                {
                    gumballMachine.SetState(gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.SetState(gumballMachine.SoldOutState);
                }
            }
        }

        public override string ToString()
        {
            return "WinnerState";
        }

        public void Refill()
        {
            Console.WriteLine("There is many of gumballs");
        }
    }
}
