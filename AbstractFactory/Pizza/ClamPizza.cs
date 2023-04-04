using AbstractFactory.IngredientFactories;

namespace AbstactFactofy.Pizza
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.createDough();
            Sauce = ingredientFactory.createSauce();
            Cheese = ingredientFactory.createCheese();
            Clam = ingredientFactory.createClam();
        }
    }
}
