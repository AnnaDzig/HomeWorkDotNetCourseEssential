using Calculator_Task;

class Program
{

    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Calculator calculator = new Calculator();
     

        while (true) {
            try
            {
                Console.Write("Введіть перше число: ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Введіть друге число: ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Оберіть операцію (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result;

                switch (operation)
                {
                    case "+":
                        result = calculator.Add(x, y);
                        break;
                    case "-":
                        result = calculator.Sub(x, y);
                        break;
                    case "*":
                        result = calculator.Mul(x, y);
                        break;
                    case "/":
                        result = calculator.Div(x, y);
                        break;
                    default:
                        throw new InvalidOperationException("Операція не розпізнана.");
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException ) 
            {
                Console.WriteLine("Помилка: введено некоректне число. Спробуйте ще раз.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Невідома помилка: {ex.Message}");
            }

            // Запит на продовження
            Console.WriteLine("Бажаєте виконати ще одну операцію? (y/n): ");
            string continueOperation = Console.ReadLine();
            if (continueOperation.ToLower() != "y")
            {
                break;
            }
        }

        Console.WriteLine("Дякуємо за використання калькулятора!");
    }
}