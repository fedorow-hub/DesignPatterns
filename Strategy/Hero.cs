using Strategy.Strategies;

namespace Strategy
{
    public class Hero
    {
        private readonly string _name;
        IWeapon _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>>>");

            if (_weapon == null)
            {
                Console.WriteLine($"{_name} can't attack withont a weapon. Set a weapon");
            }
            else
            {
                Console.Write($"{_name}");
                _weapon.Shoot();
            }
        }
    }
}
