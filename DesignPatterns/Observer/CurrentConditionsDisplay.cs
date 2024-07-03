namespace Observer;

public class CurrentConditionsDisplay : IObserver
{
    private float temperature;
    private float humidity;

    public void Update(float temp, float hum, float press)
    {
        this.temperature = temp;
        this.humidity = hum;

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions:" +
            $"{temperature}F degrees and {humidity}% humidity");
    }
}
