using AbstactFactofy.Pizza;
using AbstractFactory.IngredientFactories;

namespace AbstactFactofy.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza.Pizza createPizza(string item)
        {
            Pizza.Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
            new ChicagoPizzaIngredientFactory();
            if (item == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");

            }
            else if (item == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("Chicago Style Veggie Pizza");
            }
            else if (item == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");
            }
            return pizza;
        }
    }
}
