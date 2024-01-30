using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukos_RPPOON_Dodatni_zadatak_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherProvider = new WeatherForecastProvider();
            var weatherStatistics = new WeatherStatistics();
            var weatherDisplay = new WeatherDisplay();

            weatherProvider.Register(weatherStatistics);
            weatherProvider.Register(weatherDisplay);

            for (int i = 0; i < 5; i++)
            {
                weatherDisplay.OnWeatherChanged(Weather.Rainy);
                weatherDisplay.OnWeatherChanged(Weather.Sunny);
                weatherProvider.PeriodicUpdate();
                weatherStatistics.OnWeatherChanged(Weather.Sunny);
            }

            weatherProvider.Unregister(weatherStatistics);

            for (int i = 0; i < 3; i++)
            {
                weatherProvider.PeriodicUpdate();
                weatherDisplay.OnWeatherChanged(Weather.Cloudy);
            }
        }
    }
    public enum Weather
    {
        Sunny,
        Cloudy,
        Rainy,
        Stormy
    }

    public static class WeatherService
    {
        public static Weather GetWeatherForecast()
        {
            Random random = new Random();
            Array values = Enum.GetValues(typeof(Weather));
            return (Weather)values.GetValue(random.Next(values.Length));
        }
    }

    public interface ILiveWeatherForecast
    {
        void Register(IWeatherProcessor processor);
        void Unregister(IWeatherProcessor processor);
        void Notify();
    }

    public interface IWeatherProcessor
    {
        void OnWeatherChanged(Weather weather);
    }

    public class WeatherForecastProvider : ILiveWeatherForecast
    {
        private DateTime lastUpdate = DateTime.Now;
        private Weather currentWeather = WeatherService.GetWeatherForecast();
        private List<IWeatherProcessor> processors = new List<IWeatherProcessor>();

        public void Register(IWeatherProcessor processor)
        {
            processors.Add(processor);
        }

        public void Unregister(IWeatherProcessor processor)
        {
            processors.Remove(processor);
        }

        public void Notify()
        {
            foreach (var processor in processors)
            {
                processor.OnWeatherChanged(currentWeather);
            }

            lastUpdate = DateTime.Now;
        }

        public void PeriodicUpdate()
        {
            if (DateTime.Now >= lastUpdate.AddHours(1))
            {
                currentWeather = WeatherService.GetWeatherForecast();
                Notify();
            }
        }
    }

    public class WeatherStatistics : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            Console.WriteLine($"Weather statistics updated. Current weather: {weather}");
        }
    }

    public class WeatherDisplay : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            Console.WriteLine($"Weather display updated. Current weather: {weather}");
        }
    }
}
