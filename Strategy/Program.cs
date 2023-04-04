using Strategy;
using Strategy.Strategies;

Hero hero = new("Sqidward");

hero.Attack();

hero.SetWeapon(new Cannon());

hero.Attack();

hero.SetWeapon(new AutoGun());

hero.Attack();

Console.ReadLine();
