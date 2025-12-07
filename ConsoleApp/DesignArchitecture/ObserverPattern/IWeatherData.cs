namespace ConsoleApp.DesignArchitecture.ObserverPattern;

public interface IWeatherData // Subject/Publisher
{
    public void RegisterObserver(IWeatherObserver observer);
    public void RemoveObserver(IWeatherObserver observer);
    public void NotifyObservers();
    public void SetMeasurement(float temperature, float humidity, float pressure);
}

public class WeatherData : IWeatherData
{
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }

    // create a list or container to store the registered observers
    private IList<IWeatherObserver> _registerObservers;

    public WeatherData() =>
        _registerObservers = new List<IWeatherObserver>();


    public void RegisterObserver(IWeatherObserver observer)
    {
        if (!_registerObservers.Contains(observer))
        {
            _registerObservers.Add(observer);
            Console.WriteLine($"Observer already registered: {observer.GetType().Name}");
        }
        else
        {
            Console.WriteLine("Observer already registered");
        }
    }
    
    public void RemoveObserver(IWeatherObserver observer)
    {
        var observerIndex = _registerObservers.IndexOf(observer);
        if (observerIndex>=0)
        {
            _registerObservers.Remove(observer);
            Console.WriteLine($"Observer removed from register: {observer.GetType().Name}");
        }
    }

    public void NotifyObservers()
    {
        // loop through the list of observers and call their update method
        foreach (var observer in _registerObservers)
        {
            observer.Update(Temperature, Humidity, Pressure);
        }
    }

    
    // Non shared method to set measurements
    public void MeasurementsChanged()
    {
        NotifyObservers();
    }
    
    public void SetMeasurement(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}