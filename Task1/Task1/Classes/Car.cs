using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Car : Transport
    {
        public override int Speed { get; set; }
        public override int PassengerCount { get; set; }

        public Car(int speed, int passengerCount) : base(speed, passengerCount) { }

        public override void Move()
        {
            Console.WriteLine("Машина едет.");
        }
    }
}
