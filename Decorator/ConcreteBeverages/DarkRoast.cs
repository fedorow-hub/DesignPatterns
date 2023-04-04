namespace Decorator.ConcreteBeverages
{
    public class DarkRoast : Beverage
    {
        //public DarkRoast()
        //{
        //    desctiption = "Dark roast";
        //}
        public override double Cost()
        {
            return .99;
        }

        public override string GetDescription()
        {
            return "Dark roast";
        }
    }
}
