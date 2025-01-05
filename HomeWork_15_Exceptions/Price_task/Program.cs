//Oписати структуру з іменем Price, що містить такі поля:
// • назва товару;
// • назва магазину, де продається товар;
// • вартість товару у гривнях.
// Написати програму, яка виконує такі дії:
// • введення з клавіатури даних до масиву, що складається з двох елементів типу Price (записи мають бути впорядковані в алфавітному порядку за назвами магазинів);
// • виведення на екран інформації про товари, що продаються в магазині, назва якого введена з клавіатури (якщо такого магазину немає, вивести виняток).

struct Price
{
    public string ProductName;
    public string StoreName;
    public decimal ProductPrice;
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Price[] prices = new Price[2];

        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Введіть дані для товару #{i + 1}:");

            Console.Write("Назва магазину: ");
            prices[i].ProductName = Console.ReadLine();

            Console.WriteLine("Вартість товару (у гривнях): ");
            try
            {
                prices[i].ProductPrice = decimal.Parse(Console.ReadLine());
                if (prices[i].ProductPrice < 0)
                {
                    throw new ArgumentOutOfRangeException("Вартість не може бути від'ємною.");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено некоректну вартість. Спробуйте ще раз.");
                i--;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                i--;
            }
        }

        Array.Sort(prices, (p1,p2) => string.Compare(p1.StoreName, p2.StoreName));
        Console.WriteLine("\nСписок товарів (впорядкований за назвою магазину):");
        foreach (var price  in prices) 
        {
            Console.WriteLine($"Магазин: {price.StoreName}, Товар: {price.ProductName}, Вартість: {price.ProductPrice} грн");
        }
        Console.Write("\nВведіть назву магазину для пошуку: ");

        string storeName = Console.ReadLine();

        bool found = false;

        try
        {
            foreach (var price in prices)
            {
                if (price.StoreName.Equals(storeName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    Console.WriteLine($"Товар: {price.ProductName}, Вартість: {price.ProductPrice} грн");
                }
            }
            if (!found)
            {
                throw new Exception("Магазин із такою назвою не знайдено.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}