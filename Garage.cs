using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Garage
    {
        List<Car> cars = new List<Car>();
        List<Bicycle> bicycles = new List<Bicycle>();
        List<Lorry> lorrys = new List<Lorry>();

        public void AddBicycle()
        {
            Console.WriteLine($"Введите цену:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите максимальную скорость:");
            int maxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите год:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите количество пассажиров:");
            int maxPassangers = int.Parse(Console.ReadLine());

            bicycles.Add(new Bicycle(price, maxSpeed, year, maxPassangers));
        }

        public void AddCar()
        {
            Console.WriteLine($"Введите цену:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите максимальную скорость:");
            int maxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите год:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите мощность автомобиля:");
            int power = int.Parse(Console.ReadLine());

            cars.Add(new Car(price, maxSpeed, year, power));
        }

        public void AddLorry()
        {
            Console.WriteLine($"Введите цену:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите максимальную скорость:");
            int maxSpeed = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите год:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите максимальную ёмкость:");
            int maxCapacity = int.Parse(Console.ReadLine());

            bicycles.Add(new Bicycle(price, maxSpeed, year, maxCapacity));
        }

        public void GetAllBicycle()
        {
            Console.WriteLine("Велосипеды:");
            foreach(Bicycle b in bicycles)
            {
                Console.WriteLine($"Цена: {b.Price}\tМаксимальная скорость: {b.MaxSpeed}\tГод: {b.Year}\tМаксимум пассажиров: {b.MaxPassengers}");
            }
        }

        public void GetAllCar()
        {
            Console.WriteLine("Автомобили:");
            foreach (Car c in cars)
            {
                Console.WriteLine($"Цена: {c.Price}\tМаксимальная скорость: {c.MaxSpeed}\tГод: {c.Year}\tМощность автомобиля: {c.Power}");
            }
        }

        public void GetAllLorry()
        {
            Console.WriteLine("Грузовики:");
            foreach (Lorry b in lorrys)
            {
                Console.WriteLine($"Цена: {b.Price}\tМаксимальная скорость: {b.MaxSpeed}\tГод: {b.Year}\tМаксимальная ёмкость: {b.MaxCapacity}");
            }
        }
    }
}
