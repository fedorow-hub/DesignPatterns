namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Chicago Grated Reggiano Cheese");
        }
    }
}
