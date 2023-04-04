using SimpleFactory;

PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());

pizzaStore.orderPizza("veggie");

Console.ReadLine();
