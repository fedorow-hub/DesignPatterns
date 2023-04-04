using Observer.Observers;

namespace Observer.Subjects
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public float GetTemperature();

        public float GetPressure();

        public float GetHumidity();

        public void NoticeObservers();
    }
}
