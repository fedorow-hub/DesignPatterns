using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.SomeVeggies;
using System;

namespace AbstactFactofy.Pizza
{
    public abstract class Pizza
    {
        public string? Name { get; set; }
        public Dough? Dough { get; set; }
        public Sauce? Sauce { get; set; }
        public Veggies[]? Veggies { get; set; }
        public Cheese? Cheese { get; set; }
        public Pepperoni? Pepperoni { get; set; }
        public Clams? Clam { get; set; }

        abstract public void prepare();        

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string? getName()
        {
            return Name;
        }

        public void setName(string? name)
        {
            this.Name = name;
        }
    }
}
