class Car
{
    public string Name { get; }
    public int Year { get; }


    public Car(string name, int year)
    {
        Name = name;
        Year = year;
    }
}

class CarCollection
{
    private readonly List<Car> cars = new List<Car>();

    public void AddCar(string name, int year)
    {
        cars.Add(new Car(name, year));
    }

    public Car this[int index] => cars[index];

    public int Count => cars.Count;

    public void Clear() => cars.Clear();
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8; 

        CarCollection carPark = new CarCollection();

        carPark.AddCar("BMW 420", 2015);
        carPark.AddCar("Volvo CX90", 2020);
        carPark.AddCar("Audi A5", 2023);

        Console.WriteLine("Список машин у автопарку:");
        for (int i = 0; i < carPark.Count; i++)
        {
            var car = carPark[i];
            Console.WriteLine($"{i + 1}. {car.Name}, {car.Year}");
        }

        Console.WriteLine($"\nКількість машин у автопарку: {carPark.Count}");

        carPark.Clear();
        Console.WriteLine("\nВсі машини видалено.");
        Console.WriteLine($"Кількість машин після очищення: {carPark.Count}");

    }
}