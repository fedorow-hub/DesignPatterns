namespace Facade.Components
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Theater lights is on");
        }

        public void Off()
        {
            Console.WriteLine("Theater lights is off");
        }

        public void Dim(int dim)
        {
            Console.WriteLine($"Theater lights is {dim} lum");
        }

        public override string ToString()
        {
            return "Theater lights";
        }
    }
}
