using System;

namespace DriveSimulator.Transports
{
    public abstract class Transport
    {
        public string Name { get; }
        public abstract double Speed { get; }

        protected Transport(string name)
        {
            Name = name;
        }

        public abstract double CalculateTime(double distance, Weather weather);
    }
}