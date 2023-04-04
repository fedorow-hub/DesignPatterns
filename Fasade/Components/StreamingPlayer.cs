using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Components
{
    public class StreamingPlayer
    {
        public void On()
        {
            Console.WriteLine("Player is on");
        }
        public void Off()
        {
            Console.WriteLine("Player is off");
        }
        public void Pause()
        {
            Console.WriteLine("Player is paused");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"Player is play {movie}");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("Audio is surround");
        }
        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Audio is stereo");
        }
        public void Stop()
        {
            Console.WriteLine("Player is stoped");
        }
        public override string ToString()
        {
            return "Streaming player";
        }
    }
}
