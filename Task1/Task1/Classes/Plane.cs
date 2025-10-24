using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Plane : Transport
    {
        public double Length { get; set; }
        public double Wingspan { get; set; }

        public override int Speed { get; set; }
        public override int PassengerCount { get; set; }

        public Plane(int speed, int passengerCount, double length, double wingspan) : base(speed, passengerCount)
        {
            Length = length;
            Wingspan = wingspan;
        }

        public override void Move()
        {
            Console.WriteLine("Самолет летит.");
        }
    }
}
