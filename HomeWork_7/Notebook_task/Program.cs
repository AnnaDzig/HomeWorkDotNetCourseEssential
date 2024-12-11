using System.Diagnostics;
using System.Reflection;

struct Notebook
{
    public string Model;
    public string Manufacturer;
    public decimal Price;


    public Notebook(string model, string manufacturer, decimal price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Виробник: {Manufacturer}");
        Console.WriteLine($"Ціна: {Price} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        Notebook notebook1 = new Notebook("XPS 15", "Dell", 50000m);
        Notebook notebook2 = new Notebook("MacBook Pro", "Apple", 90000m);


        Console.WriteLine("Інформація про ноутбуки:");
        notebook1.DisplayInfo();

        Console.WriteLine(); 

        notebook2.DisplayInfo();

        Console.ReadKey(); 
    }
}