namespace GrpcServicewhithProxy
{
    public class GumballMachine
    {
        IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;
        IState winnerState;

        IState state;
        string location;
        int count = 0;

        public GumballMachine(int numberGumballs, string location)
        {
            this.soldOutState = new SoldOutState(this);
            this.noQuarterState = new NoQuarterState(this);
            this.hasQuarterState = new HasQuarterState(this);
            this.soldState = new SoldState(this);
            this.winnerState = new WinnerState(this);
            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }

            this.location = location;
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }
        public void EjectQuarter()
        {
            state.EjectQuarter();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }
        public void SetState(IState state)
        {
            this.state = state;
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public void Refill(int count)
        {
            Console.WriteLine($"Add {count} gumballs");
            this.count = this.count + count;
            state.Refill();
        }

        public IState SoldOutState { get { return soldOutState; } }
        public IState NoQuarterState { get { return noQuarterState; } }
        public IState HasQuarterState { get { return hasQuarterState; } }
        public IState SoldState { get { return soldState; } }
        public IState WinnerState { get { return winnerState; } }
        public int Count { get { return count; } }
        public IState State { get { return state; } }

        public string Location { get { return location; } }

        public override string ToString()
        {
            return $"GumballMachine have {count} gumball and is {state.ToString()}";
        }
    }
}
