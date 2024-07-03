namespace Observer;
public class WeatherData : ISubject
{
    private List<IObserver> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver o) =>
        observers.Add(o);

    public void MeasurementsChanged() =>
        NotifyObservers();

    public void NotifyObservers()
    {
        foreach (var observer in observers)
            observer.Update(temperature, humidity, pressure);
    }

    public void SetMeasurements(float t, float h, float p)
    {
        this.temperature = t;
        this.humidity = h;
        this.pressure = p;
        MeasurementsChanged();
    }
}
