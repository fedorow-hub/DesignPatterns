using FactoryMethod.Pizza.ChicagoStylePizza;

namespace FactoryMethod.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza.Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type == "pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else if (type == "clam")
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            else return null;
        }
    }
}
