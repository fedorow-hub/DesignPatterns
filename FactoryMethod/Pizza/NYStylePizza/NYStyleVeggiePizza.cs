namespace FactoryMethod.Pizza.NYStylePizza
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "New York Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";            
            toppings.Add("Tomato");
        }
    }
}
