namespace CarDealership
{
class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>
        {
             new Car { Brand = "Toyota", Model = "Land Cruiser", Year = 2020, Color = "White" },
                new Car { Brand = "Ford", Model = "Focus", Year = 2018, Color = "Black" },
                new Car { Brand = "BMW", Model = "X5", Year = 2022, Color = "Blue" },
                new Car { Brand = "Honda", Model = "Civic", Year = 2019, Color = "Red" }
        };

        var buyers = new List<Buyer>
        {
              new Buyer { CarModel = "Land Cruiser", Name = "Anna Dzhyhota", PhoneNumber = "123-456-7890" },
                new Buyer { CarModel = "X5", Name = "Marcin Malkiewich", PhoneNumber = "987-654-3210" }
        };

        // LINQ-запит

        var result = from buyer in buyers
                     join car in cars on buyer.CarModel equals car.Model
                     select new
                     {
                         BuyerName = buyer.Name,
                         BuyerPhoneNumber = buyer.PhoneNumber,
                         CarBrand = car.Brand,
                         CarModel = car.Model,
                         CarYear = car.Year,
                         CarColor = car.Color
                     };
        foreach (var item in result)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Покупець: {item.BuyerName}\nТелефон: {item.BuyerPhoneNumber}\nАвтомобіль: {item.CarBrand} {item.CarModel}, {item.CarYear}, {item.CarColor}\n");
        }
        Console.ReadLine();
    }
}
} 