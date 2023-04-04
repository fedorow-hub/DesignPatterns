namespace Strategy.Strategies
{
    public class Cannon : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Shoot with a cannon");
        }
    }
}
