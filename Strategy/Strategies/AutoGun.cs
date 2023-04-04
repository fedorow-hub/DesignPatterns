namespace Strategy.Strategies
{
    public class AutoGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Shoot with a auto gun");
        }
    }
}
