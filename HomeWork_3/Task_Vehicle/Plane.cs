using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle
{
    public class Plane : Vehicle
    {
        public double Altitude { get; set; } // Висота
        public int Passengers { get; set; } // Кількість пасажирів

        public Plane(double coordinateX, double coordinateY, double price, double speed, int yearOfManufacture, double altitude, int passengers)
       : base(coordinateX, coordinateY, price, speed, yearOfManufacture)
        {
            Altitude = altitude;
            Passengers = passengers;
        }

        public new void DisplayInfo()
        {
            base.DisplayInfo(); 
            Console.WriteLine($"Altitude: {Altitude} meters");
            Console.WriteLine($"Passengers: {Passengers}");
        }

    }
}