// See https://aka.ms/new-console-template for more information
using Task_Vehicle;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкти для кожного виду транспорту
        Plane plane = new Plane(10.5, 20.3, 500000, 900, 2022, 10000, 150);
        Car car = new Car(5.0, 7.5, 20000, 120, 2020, 4);
        Ship ship = new Ship(100.2, 200.3, 2000000, 50, 2015, 500, "Port of Odessa");

        // Виводимо інформацію про кожен засіб пересування
        Console.WriteLine("Plane Info:");
        plane.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Car Info:");
        car.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Ship Info:");
        ship.DisplayInfo();

        // Додаємо паузу, щоб консольне вікно не закрилося одразу
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}