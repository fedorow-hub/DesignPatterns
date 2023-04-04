using FactoryMethod.Pizza;
using FactoryMethod.PizzaStores;

PizzaStore NYPizzaStore = new NYPizzaStore();
PizzaStore ChicagoPizzaStore = new ChicagoPizzaStore();

Pizza pizza = NYPizzaStore.orderPizza("cheese");
Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

pizza = ChicagoPizzaStore.orderPizza("cheese");
Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

Console.ReadLine();
