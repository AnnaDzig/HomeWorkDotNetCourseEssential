class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість елементів масиву (N): ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array[0];
        int min = array[0];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (array[i] > max)
                max = array[i];

            if (array[i] < min)
                min = array[i];

            sum += array[i];
        }

        double average = (double)sum / n;

        Console.WriteLine("\nНепарні значення:");
        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 != 0)
            {
                Console.Write(array[i] + " ");
            }
        }

        // Виведення результатів

        Console.WriteLine($"\n\nНайбільше значення: {max}");
        Console.WriteLine($"Найменше значення: {min}");
        Console.WriteLine($"Сума елементів: {sum}");
        Console.WriteLine($"Середнє арифметичне: {average:F2}");


        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}