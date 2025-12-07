namespace ConsoleApp.DesignArchitecture.ObserverPattern;

public interface IWeatherObserver // Subscriber/Observer
{
    public void Update(float temp, float humidity, float pressure);
}

public class WeatherObserverOne : IWeatherObserver, IDisplayWeatherInformation
{
    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temp, float humidity, float pressure)
    {
        throw new NotImplementedException();
    }
}

public class WeatherObserverTwo : IWeatherObserver, IDisplayWeatherInformation
{

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temp, float humidity, float pressure)
    {
        throw new NotImplementedException();
    }
}

public class WeatherObserverThree : IWeatherObserver, IDisplayWeatherInformation
{


    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Update(float temp, float humidity, float pressure)
    {
        throw new NotImplementedException();
    }
}

public class WeatherObserverFour : IWeatherObserver, IDisplayWeatherInformation
{
    public void Update(float temp, float humidity, float pressure)
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        throw new NotImplementedException();
    }
}