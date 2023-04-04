using TemplateMethod;

CaffeineBeverage myTea = new Tea();
CaffeineBeverage coffee = new Coffee();

myTea.PrepareRecipe();

coffee.PrepareRecipe();

Console.ReadLine();
