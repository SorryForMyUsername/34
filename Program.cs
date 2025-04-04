using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            while (true)
            {
                Console.WriteLine("Выберите нужное Вам действие:\n" +
                    "\t\t1. Добавить в список велосипед;\n" +
                    "\t\t2. Добавить в список машину;\n" +
                    "\t\t3. Добавить в список грузовик;\n" +
                    "\t\t4. Вывести все велосипеды из списка;\n" +
                    "\t\t5. Вывести все машины из списка;\n" +
                    "\t\t6. Вывести все грузовики из списка;\n" +
                    "\t\t7. Выход");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: myGarage.AddBicycle(); break;
                    case 2: myGarage.AddCar(); break;
                    case 3: myGarage.AddLorry(); break;
                    case 4: myGarage.GetAllBicycle(); break;
                    case 5: myGarage.GetAllCar(); break;
                    case 6: myGarage.GetAllLorry(); break;
                    case 7: return;
                    default: Console.WriteLine(""); break;
                }
            }

            Console.ReadKey(true);
        }
    }
}
