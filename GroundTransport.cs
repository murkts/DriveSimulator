using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}