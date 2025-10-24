using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    abstract class Transport
    {
        public abstract int Speed { get; set; }
        public abstract int PassengerCount { get; set; }

        public Transport(int speed, int passengerCount)
        {
            Speed = speed;
            PassengerCount = passengerCount;
        }

        public abstract void Move();
    }
}
