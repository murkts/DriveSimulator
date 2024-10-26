using DriveSimulator.Transports.Air;
using DriveSimulator.Transports.Ground;
using DriveSimulator.Transports;
using System;

namespace DriveSimulator
{
    public enum WeatherCondition
    {
        Sunny,
        Rainy,
        Windy,
        Foggy
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
                case WeatherCondition.Sunny:
                    return 1.0;
                case WeatherCondition.Rainy:
                    return transport is GroundTransport ? 0.8 : 1.0;
                case WeatherCondition.Windy:
                    return transport is AirTransport ? 0.9 : 1.0;
                case WeatherCondition.Foggy:
                    return 0.7;
                default:
                    return 1.0;
            }
        }
    }
}
