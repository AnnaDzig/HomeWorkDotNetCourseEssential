
namespace ConsoleApp
{

    enum Colors
    {
        Black = 0,
        DarkBlue = 1,
        DarkGreen = 2,
        DarkCyan = 3,
        DarkRed = 4,
        DarkMagenta = 5,
        DarkYellow = 6,
        Gray = 7,
        DarkGray = 8,
        Blue = 9,
        Green = 10,
        Cyan = 11,
        Red = 12,
        Magenta = 13,
        Yellow = 14,
        White = 15
    }

    static class TextPrinter
    {
        public static void Print(string stroka, int color)
        {
            if (Enum.IsDefined(typeof(Colors), color))
            {
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(stroka);
                Console.ResetColor(); 
            }
            else
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Некоректний вибір кольору.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Виберіть колір для тексту:");
            foreach (var color in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{(int)color}: {color}");
            }

            Console.Write("Введіть рядок для виведення: ");
            string userInput = Console.ReadLine();

            Console.Write("Введіть номер кольору (0-15): ");
            int colorChoice = int.Parse(Console.ReadLine());

            TextPrinter.Print(userInput, colorChoice);

            Console.ReadKey();
        }
    }
}

