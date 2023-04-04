using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.NYIngredients;
using AbstractFactory.Ingredients.SomeVeggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.IngredientFactories
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = { new Garlic(), 
                new Onion(), 
                new Mushroom(), 
                new RedPepper() };
            return veggies;
        }
    }
}
