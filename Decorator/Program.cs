using Decorator;
using Decorator.ConcreteBeverages;
using Decorator.ConcreteDecorators;

Beverage espresso = new Espresso();
espresso = new Mocha(espresso);

Console.WriteLine($"Напиток: {espresso.GetDescription()}, цена: {espresso.Cost()}");

Beverage darkRoast = new DarkRoast();
darkRoast = new Mocha(darkRoast);
darkRoast = new Mocha(darkRoast);
darkRoast = new Soy(darkRoast);
darkRoast = new Whip(darkRoast);

Console.WriteLine($"Напиток: {darkRoast.GetDescription()}, цена: {darkRoast.Cost()}");

Console.ReadLine();

















