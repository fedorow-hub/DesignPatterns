

using Observer.Observers;

namespace Observer.Subjects
{
    public class WeatherData : ISubject
    {

        private float pressure;
        private float temperature;
        private float humidity;

        List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NoticeObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update();
            }
        }

        public float GetTemperature()
        {
            return temperature;
        }

        public float GetPressure()
        {
            return pressure;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public void MeasurementsChanged()
        {
            NoticeObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
