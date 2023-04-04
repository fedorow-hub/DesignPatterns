namespace Facade.Components
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is On");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is Off");
        }

        public void SetStreamingPlayer(StreamingPlayer player) 
        {
            Console.WriteLine($"{player.ToString()} is selected");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier stereo sound on");
        }
        public void SetSurroundSoud()
        {
            Console.WriteLine("Amplifier surround sound on (5 speakers, 1 subwoofer)");
        }
        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine($"{tuner.ToString()} is selected");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine($"Volume is {volume}");
        }
        public override string ToString()
        {
            return "Amplifer";
        }
    }
}
