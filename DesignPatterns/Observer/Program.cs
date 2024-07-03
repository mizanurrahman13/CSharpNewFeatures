using Observer;

WeatherData weatherData = new WeatherData();

CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay();

weatherData.RegisterObserver(currentConditionsDisplay);

weatherData.SetMeasurements(80, 65, 30.4f);
