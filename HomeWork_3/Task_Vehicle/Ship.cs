using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle
{
    public class Ship : Vehicle
    {
        public int Passengers { get; set; } // Кількість пасажирів
        public string PortOfRegistry { get; set; } // Порт приписки

        public Ship(double coordinateX, double coordinateY, double price, double speed, int yearOfManufacture, int passengers, string portOfRegistry)
                : base(coordinateX, coordinateY, price, speed, yearOfManufacture)
        {
            Passengers = passengers;
            PortOfRegistry = portOfRegistry;
        }

        // Перевизначений метод для виведення інформації про корабель
        public new void DisplayInfo()
        {
            base.DisplayInfo(); // Викликаємо метод базового класу
            Console.WriteLine($"Passengers: {Passengers}");
            Console.WriteLine($"Port of Registry: {PortOfRegistry}");
        }
    }
}
