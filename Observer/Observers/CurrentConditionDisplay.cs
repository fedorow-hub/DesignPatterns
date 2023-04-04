using Observer.Subjects;

namespace Observer.Observers
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private float pressure;
        private float temperature;
        private float humidity;
        private ISubject _subject;

        public CurrentConditionDisplay(ISubject subject)
        {
            this._subject = subject;
            _subject.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine($"Current temperature: {temperature}, current pressure: {pressure}, current humidity: {humidity}");
        }

        public void Update()
        {
            this.pressure = _subject.GetPressure();
            this.temperature = _subject.GetTemperature();
            this.humidity = _subject.GetHumidity();
            Display();
        }
    }
}
