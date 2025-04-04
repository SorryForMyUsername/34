using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    /// <summary>
    /// Грузовик
    /// </summary>
    class Lorry : Vehicle
    {
        int maxCapacity;

        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }

        public Lorry(int price, int maxSpeed, int releaseYear, int maxCapacity) : base(price, maxSpeed, releaseYear)
        {
            MaxCapacity = maxCapacity;
        }
    }
}
