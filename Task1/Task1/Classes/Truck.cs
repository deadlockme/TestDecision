using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    internal class Truck : Car
    {
        public int LoadCapacity { get; set; }

        public Truck(int speed, int passengerCount, int loadCapacity) : base(speed, passengerCount)
        {
            LoadCapacity = loadCapacity;
        }
    }
}
