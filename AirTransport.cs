using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSimulator
{
    public class AirTransport : Transport
    {
        public double AccelerationCoefficient { get; }
        public AirTransport(string name, double speed, double accelerationCoefficient)
            : base(name)
        {
            Speed = speed;
            AccelerationCoefficient = accelerationCoefficient;
        }
        public override double Speed { get; }
    }
}