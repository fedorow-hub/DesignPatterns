namespace Strategy.Strategies
{
    public class Gun : IWeapon
    {       

        public void Shoot()
        {
            Console.WriteLine("Shoot with a gun");
        }
    }
}
