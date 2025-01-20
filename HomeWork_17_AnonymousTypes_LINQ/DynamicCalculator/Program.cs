namespace DynamicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            dynamic sum = calculator.Add(5, 10);
            dynamic difference = calculator.Subtract(15, 5);
            dynamic product = calculator.Multiply(4, 3);
            dynamic quotient = calculator.Divide(20, 4);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.ReadLine();
        }
    }
}