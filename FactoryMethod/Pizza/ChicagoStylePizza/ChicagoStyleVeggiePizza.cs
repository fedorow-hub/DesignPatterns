namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";            
            toppings.Add("Tomato");
        }
    }
}
