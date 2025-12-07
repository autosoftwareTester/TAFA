namespace ConsoleApp.DesignArchitecture.ObserverPattern;

public interface IDisplayWeatherInformation
{
    public void Display();
}

public class StatisticDisplay : IDisplayWeatherInformation, IWeatherObserver
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }
    private IWeatherData _weatherData;

    public StatisticDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Displaying weather statistics...");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        Display();
    }
}

public class CurrentConditionDisplay : IDisplayWeatherInformation, IWeatherObserver
{
    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }
    private IWeatherData _weatherData;

    public CurrentConditionDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Displaying weather data for third-party application...");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        Display();
    }
}

public class ForecastDisplay : IDisplayWeatherInformation, IWeatherObserver
{
    private float Temperature { get; set; }
    private float Humidity { get; set; }
    private float Pressure { get; set; }
    private IWeatherData _weatherData;

    public ForecastDisplay(IWeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        Console.WriteLine("Displaying weather data on home display...");
    }

    public void Update(float temp, float humidity, float pressure)
    {
        Temperature = temp;
        Humidity = humidity;
        Pressure = pressure;
        Display();
    }
}