class Program
{
    static void Main(string[] args)
 {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
   
        Func<int, int, int> Add = (a, b) => a + b;
        Func<int, int, int> Sub = (a, b) => a - b;
        Func<int, int, int> Mul = (a, b) => a * b;
        Func<int, int, string> Div = (a, b) => b == 0 ? "Помилка: ділення на нуль" : (a / b).ToString();

        Console.WriteLine("Введіть перше число:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Оберіть операцію: +, -, *, /");
        string operation = Console.ReadLine();

        string result = operation switch
        {
            "+" => Add(num1, num2).ToString(),
            "-" => Sub(num1, num2).ToString(),
            "*" => Mul(num1, num2).ToString(),
            "/" => Div(num1, num2),
            _ => "Невірна операція"
        };

        Console.WriteLine($"Результат: {result}");
        Console.ReadKey();
    }
}
