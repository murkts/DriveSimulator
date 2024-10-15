using System;

namespace DriveSimulator
{
    public enum WeatherCondition
    {
        Солнечно,
        Дождь,
        Ветер,
        Туман
    }

    public class Weather
    {
        public WeatherCondition Condition { get; private set; }

        public Weather(WeatherCondition condition)
        {
            Condition = condition;
        }

        public double GetSpeedMultiplier(Transport transport)
        {
            switch (Condition)
            {
                case WeatherCondition.Солнечно:
                    return 1.0;
                case WeatherCondition.Дождь:
                    return transport is GroundTransport ? 0.8 : 1.0;
                case WeatherCondition.Ветер:
                    return transport is AirTransport ? 0.9 : 1.0;
                case WeatherCondition.Туман:
                    return 0.7;
                default:
                    return 1.0;
            }
        }
    }
}
