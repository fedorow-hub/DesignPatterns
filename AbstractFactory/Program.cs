using AbstactFactofy.Pizza;
using AbstactFactofy.PizzaStores;
using AbstractFactory.Ingredients.NYIngredients;

PizzaStore NYPizzaStore = new NYPizzaStore();

PizzaStore ChicagoPizzaStore = new ChicagoPizzaStore();

Pizza pizza = NYPizzaStore.orderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

pizza = ChicagoPizzaStore.orderPizza("veggie");
Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

Console.ReadLine();
