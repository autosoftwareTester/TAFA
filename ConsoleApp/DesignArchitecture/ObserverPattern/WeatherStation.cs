namespace ConsoleApp.DesignArchitecture.ObserverPattern;
public static class WeatherStation
{
    private static readonly IWeatherData weatherData = new WeatherData();

    public static bool WeatherTest()
    {
        var currentConditionDisplay = new CurrentConditionDisplay(weatherData);
        var statisticDisplay = new StatisticDisplay(weatherData);
        var forecastDisplay = new ForecastDisplay(weatherData);

        // set measurements
        weatherData.SetMeasurement(30.5f, 65f, 1013.1f);
        return true;
    }
}