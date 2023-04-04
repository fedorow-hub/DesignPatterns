namespace FactoryMethod.Pizza.ChicagoStylePizza
{
    internal class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Clam");
        }
    }
}
