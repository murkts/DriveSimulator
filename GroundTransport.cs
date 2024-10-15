using System;
namespace DriveSimulator
{
    public class GroundTransport : Transport
    {
        public double MovementTime { get; }
        public double RestDuration { get; }

        public GroundTransport(string name, double speed, double movementTime, double restDuration)
            : base(name)
        {
            Speed = speed;
            MovementTime = movementTime;
            RestDuration = restDuration;
        }

        public override double Speed { get; }

        public override double CalculateTime(double distance, Weather weather)
        {
            double adjustedSpeed = Speed * weather.GetSpeedMultiplier(this);
            double timeInMovement = distance / adjustedSpeed;
            double totalTime = timeInMovement + (Math.Floor(timeInMovement / MovementTime) * RestDuration);
            return totalTime;
        }
    }

    public class Carriage : GroundTransport
    {
        public Carriage() : base("Карета-тыква", 20, 5, 2) { }
    }

    public class WalkingBoots : GroundTransport
    {
        public WalkingBoots() : base("Сапоги-скороходы", 50, 3, 1) { }
    }

    public class Izbushka : GroundTransport
    {
        public Izbushka() : base("Избушка на курьих ножках", 30, 7, 6) { }
    }

    public class Centaur : GroundTransport
    {
        public Centaur() : base("Кентавр", 40, 3, 3) { }
    }
}
