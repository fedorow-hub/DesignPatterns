namespace Decorator.ConcreteBeverages
{
    public class HouseBlend : Beverage
    {
        //public HouseBlend()
        //{
        //    desctiption = "House Blend Coffee";
        //}
        public override double Cost()
        {
            return .89;
        }

        public override string GetDescription()
        {
            return "House blend";
        }
    }
}
