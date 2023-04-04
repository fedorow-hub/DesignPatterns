using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.ChicagoIngredients;
using AbstractFactory.Ingredients.NYIngredients;
using AbstractFactory.Ingredients.SomeVeggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.IngredientFactories
{
    internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams createClam()
        {
            return new FrozenClams();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Spinach(),
                new EggPlant(),
                new BlackOlives(),
                new RedPepper() };
            return veggies;
        }
    }
}
