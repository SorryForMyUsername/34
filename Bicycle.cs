using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    /// <summary>
    /// Велосипед
    /// </summary>
    class Bicycle : Vehicle
    {
        int maxPassengers;

        public int MaxPassengers { get => maxPassengers; set => maxPassengers = value; }

        public Bicycle(int price, int maxSpeed, int year, int maxPassengers) : base(price, maxSpeed, year)
        {
            MaxPassengers = maxPassengers;
        }
    }
}
