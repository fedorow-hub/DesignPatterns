namespace Decorator.ConcreteBeverages
{
    public class Espresso : Beverage
    {
        //public Espresso()
        //{
        //    desctiption = "Espresso";
        //}
        public override double Cost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}
