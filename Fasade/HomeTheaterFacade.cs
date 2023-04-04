using Facade.Components;

namespace Facade
{
    public class HomeTheaterFacade
    {
        private Amplifier amp;
        private StreamingPlayer player;
        private Projector projector;
        private TheaterLights lights;
        private Screen screen;
        private PopcornPopper popper;

        public HomeTheaterFacade(
            Amplifier amp,            
            StreamingPlayer player,
            Projector projector,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popper
            )
        {
            this.amp = amp;            
            this.player = player;
            this.projector = projector;
            this.screen = screen;
            this.lights = lights;
            this.popper = popper;
        }

        public void WatchMovie(String movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            popper.On();
            popper.Pop();
            lights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMode();
            amp.On();
            amp.SetStreamingPlayer(player);
            amp.SetSurroundSoud();
            amp.SetVolume(5);
            player.On();
            player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            popper.Off();
            lights.On();
            screen.Up();
            projector.Off();
            amp.Off();
            player.Stop();
            player.Off();
        }
    }
}
