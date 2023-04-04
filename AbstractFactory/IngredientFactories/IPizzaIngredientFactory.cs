using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.SomeVeggies;
using System.Security.Claims;

namespace AbstractFactory.IngredientFactories
{
    public interface IPizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
