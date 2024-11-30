
using System;

namespace CalculatorApp
{
    public static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Помилка: ділення на нуль!");
                return double.NaN; 
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Калькулятор:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");
            Console.WriteLine();

            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Результат додавання: {Calculator.Add(num1, num2)}");
            Console.WriteLine($"Результат віднімання: {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Результат множення: {Calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Результат ділення: {Calculator.Divide(num1, num2)}");

            Console.ReadKey();
        }
    }
}
