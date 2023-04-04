namespace FactoryMethod.Pizza.NYStylePizza
{
    internal class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            Name = "New York Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Clam");
        }
    }
}
