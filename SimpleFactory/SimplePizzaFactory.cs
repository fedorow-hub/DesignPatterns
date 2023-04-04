using SimpleFactory.Pizza;

namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza.Pizza? createPizza(string type)
        {
            Pizza.Pizza? pizza = null;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza();
            }
            else if (type == "veggie")
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
