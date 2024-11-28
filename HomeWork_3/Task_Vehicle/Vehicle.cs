using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Vehicle
{
    public class Vehicle
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int YearOfManufacture { get; set; }

        public Vehicle (double coordinateX, double coordinateY, double price, double speed, int yearOfManufacture)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Price = price;
            Speed = speed;
            YearOfManufacture = yearOfManufacture;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Coordinates: ({CoordinateX}, {CoordinateY})");
            Console.WriteLine($"Price: {Price} USD");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Year of Manufacture: {YearOfManufacture}");
        }
    }
}
