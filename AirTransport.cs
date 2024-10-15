namespace DriveSimulator
{
    public abstract class AirTransport : Transport
    {
        public override double Speed { get; }
        public double AccelerationFactor { get; }

        protected AirTransport(string name, double speed, double accelerationFactor)
            : base(name)
        {
            Speed = speed;
            AccelerationFactor = accelerationFactor;
        }

        public override double CalculateTime(double distance, Weather weather)
        {
            double adjustedSpeed = Speed * weather.GetSpeedMultiplier(this);
            return distance / (adjustedSpeed * AccelerationFactor);
        }
    }

    public class Stupa : AirTransport
    {
        public Stupa() : base("Ступа Бабы-Яги", 50, 1.0) { }
    }

    public class Broomstick : AirTransport
    {
        public Broomstick() : base("Метла", 30, 1.2) { }
    }

    public class FlyingCarpet : AirTransport
    {
        public FlyingCarpet() : base("Ковер-самолет", 40, 1.1) { }
    }

    public class FlyingShip : AirTransport
    {
        public FlyingShip() : base("Летучий корабль", 30, 1.0) { }
    }
}
