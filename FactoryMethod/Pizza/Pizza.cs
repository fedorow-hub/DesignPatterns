using System;

namespace FactoryMethod.Pizza
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        
        public List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.Write("Adding toppings: ");
            foreach (string topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

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
        public string getName()
        {
            return Name;
        }
    }
}
