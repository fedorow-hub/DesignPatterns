using Facade;
using Facade.Components;

Amplifier amp = new Amplifier();
StreamingPlayer player = new StreamingPlayer();
Projector projector = new Projector();
Screen screen = new Screen();
TheaterLights lights = new TheaterLights();
PopcornPopper popcorn = new PopcornPopper();

HomeTheaterFacade homeTheater =
 new HomeTheaterFacade(amp, player,
 projector, lights, screen,  popcorn);

homeTheater.WatchMovie("Raiders of the Lost Ark");
homeTheater.EndMovie();

Console.ReadLine();
