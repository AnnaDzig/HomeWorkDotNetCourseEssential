using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle
{
    public class Car : Vehicle
    {
        public int Passengers { get; set; } // Кількість пасажирів

        public Car(double coordinateX, double coordinateY, double price, double speed, int yearOfManufacture, int passengers)
     : base(coordinateX, coordinateY, price, speed, yearOfManufacture)
        {
            Passengers = passengers;
        }
        public new void DisplayInfo()
        {
            base.DisplayInfo(); // Викликаємо метод базового класу
            Console.WriteLine($"Passengers: {Passengers}");
        }
    }
}