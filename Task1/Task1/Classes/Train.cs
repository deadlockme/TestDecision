using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Train : Transport
    {
        public int WagonsCount { get; set; }

        public override int Speed { get; set; }
        public override int PassengerCount { get; set; }

        public Train(int speed, int passengerCount, int wagonsCount) : base(speed, passengerCount)
        {
            WagonsCount = wagonsCount;
        }

        public override void Move()
        {
            Console.WriteLine("Поезд едет.");
        }
    }
}
