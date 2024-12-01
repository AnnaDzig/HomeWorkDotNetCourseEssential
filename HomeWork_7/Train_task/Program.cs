
struct Train
{
    public string Destination;
    public int TrainNumber;
    public string DepartureTime;

    public Train(string destination, int trainNumber, string departureTime)
    {  Destination = destination; TrainNumber = trainNumber; DepartureTime = departureTime;}

    public void DisplayInfo()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Поїзд №{TrainNumber}, пункт призначення: {Destination}, час відправлення: {DepartureTime}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[8];

        for (int i = 0; i < trains.Length; i++)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine($"Введіть дані для поїзда {i + 1}:");
            Console.Write("Пункт призначення: ");
            string destination = Console.ReadLine();
            Console.Write("Номер поїзда: ");
            int trainNumber = int.Parse(Console.ReadLine());
            Console.Write("Час відправлення (години:хвилини у форматі год:хв): ");
            string departureTime = Console.ReadLine();

            trains[i] = new Train(destination, trainNumber, departureTime);
            Console.Write("Введіть номер поїзда для пошуку: ");
            int searchNumber = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (var train in trains)
            {
                if (train.TrainNumber == searchNumber)
                {
                    train.DisplayInfo();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Поїзд із номером {searchNumber} не знайдено.");
            }
        }
    }
}