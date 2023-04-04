namespace Facade.Components
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner is on");
        }

        public void Off()
        {
            Console.WriteLine("Tuner is off");
        }

        public void SetAm()
        {
            Console.WriteLine("Tuner is Am band reception");
        }

        public void SetFm()
        {
            Console.WriteLine("Tuner is Fm band reception");
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine($"Tuner is {frequency} frequency");
        }

        public override string ToString()
        {
            return "Tuner";
        }
    }
}
