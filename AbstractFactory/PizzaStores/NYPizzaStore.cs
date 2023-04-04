using AbstactFactofy.Pizza;
using AbstractFactory.IngredientFactories;

namespace AbstactFactofy.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza.Pizza createPizza(string item)
        {
            Pizza.Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
            new NYPizzaIngredientFactory();
            if (item == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");

            }
            else if (item == "veggie")
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");
            }
            else if (item == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");
            }            
            return pizza;
        }        
    }
}
