using AbstractFactory.IngredientFactories;

namespace AbstactFactofy.Pizza
{
    public class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = ingredientFactory.createDough();
            Sauce = ingredientFactory.createSauce();
            Cheese = ingredientFactory.createCheese();
            Veggies = ingredientFactory.createVeggies();
        }
    }
}
