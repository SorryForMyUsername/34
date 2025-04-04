using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    /// <summary>
    /// Автомобиль
    /// </summary>
    class Car : Vehicle
    {
        int power;

        public int Power { get => power; set => power = value; }

        public Car(int price, int maxSpeed, int releaseYear, int power) : base(price, maxSpeed, releaseYear)
        {
            Power = power;
        }
    }
}
