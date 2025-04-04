using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    /// <summary>
    /// Транспортное средство
    /// </summary>
    abstract class Vehicle
    {
        int price;
        int maxSpeed;
        int year;

        public int Price { get => price; set => price = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
        public int Year { get => year; set => year = value; }

        public Vehicle(int price, int maxSpeed, int year)
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
        }
    }
}
