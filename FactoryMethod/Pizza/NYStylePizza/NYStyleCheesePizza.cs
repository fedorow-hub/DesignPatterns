namespace FactoryMethod.Pizza.NYStylePizza
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "New York Style Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("New York Grated Reggiano Cheese");
        }
    }
}
