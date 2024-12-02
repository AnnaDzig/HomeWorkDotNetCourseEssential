class Program
{
    delegate double Calc(int a, int b, int c, double result);
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Calc calculateAverage = (a, b, c, result) => a + b + c / result;

        double result = calculateAverage(15, 3, 10, 3.0);
        Console.WriteLine($"Сума: {result}");
        Console.ReadKey();
    }
}
