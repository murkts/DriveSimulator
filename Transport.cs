using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveSimulator
{
    public abstract class Transport
    {
        public string Name { get; }
        public abstract double Speed { get; }
        protected Transport(string name)
        {
            Name = name;
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
    public class Stupa : AirTransport
    {
        public Stupa() : base("Ступа Бабы-Яги", 50, 1.0) { }
    }

    public class Carriage : GroundTransport
    {
        public Carriage() : base("Карета-тыква", 20, 5, 2) { }
    }
}