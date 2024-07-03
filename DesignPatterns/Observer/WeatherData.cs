/*
 * What is the Observer Design Pattern? 🤔 

How do you think you could implement it?

The Observer Pattern is useful when you have a "single source of truth" that multiple other components need to be in
sync with.

The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency between objects 
so that when one object changes state, all its dependents are notified and updated automatically.

The pattern essentially establishes a broadcast mechanism where the "subject" broadcasts updates,
and the "observers" receive these updates.

I create a simple C# example that illustrates the Observer pattern using the weather station scenario. 
You can check it below.

 */

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
