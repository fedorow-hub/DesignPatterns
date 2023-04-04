using Adapter;

IDuck duck = new MallardDuck();
ITurkey turkey = new WildTurkey();

IDuck turkeyAdapter = new TurkeyAdapter(turkey);

Console.WriteLine("The Turkey says...");
turkey.gobble();
turkey.fly();
Console.WriteLine("\nThe Duck says...");
testDuck(duck);

Console.WriteLine("\nThe TurkeyAdapter says...");
testDuck(turkeyAdapter);

Console.ReadLine();

static void testDuck(IDuck duck)
{
    duck.quack();
    duck.fly();
}
