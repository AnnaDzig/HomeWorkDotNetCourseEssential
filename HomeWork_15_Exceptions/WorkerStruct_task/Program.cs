//описати структуру з ім'ям Worker, що містить такі поля:
// • прізвище та ініціали працівника;
// • назва займаної посади;
// • рік надходження працювати.

// Написати програму, яка виконує такі дії:
// • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
// • якщо значення року введено не у відповідному форматі видає виняток;
// • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.


struct Worker
{
    public string FullName;
    public string Position;
    public int YearStarted;
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Worker[] workers = new Worker[5];

        for (int i = 0; i < workers.Length; i++)
        {
            Console.WriteLine($"Введіть дані для працівника #{i + 1}");

            Console.Write("Прізвище та ініціали: ");
            workers[i].FullName = Console.ReadLine();

            Console.WriteLine("Посада: ");
            workers[i].Position = Console.ReadLine();

            Console.Write("Рік надходження працювати: ");

            try
            {
                workers[i].YearStarted = int.Parse(Console.ReadLine());
                if (workers[i].YearStarted < 1900 || workers[i].YearStarted > DateTime.Now.Year)
                {
                    throw new FormatException("Рік має бути у межах 1900 і поточного року.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
                i--;
            }
        }

        Array.Sort(workers, (w1, w2) => string.Compare(w1.FullName, w2.FullName));
        Console.WriteLine("\nСписок працівників (впорядкований за абеткою):");
        foreach (Worker worker in workers)
        {
            Console.WriteLine($"Прізвище: {worker.FullName}, Посада: {worker.Position}, Рік початку роботи: {worker.YearStarted}");
        }


        int minExperience = 0;
        bool isInputValid = false;

        while (!isInputValid) {
            try
            {
                Console.Write("\nВведіть мінімальний стаж роботи: ");
                minExperience = int.Parse(Console.ReadLine());

                if (minExperience < 0)
                {
                    throw new ArgumentOutOfRangeException("Стаж не може бути від'ємним.");
                }

                isInputValid = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено некоректне значення. Будь ласка, введіть ціле число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("Спробуйте ще раз.");
            }
        }

        int currentYear = DateTime.Now.Year;

        Console.WriteLine("\nПрацівники зі стажем більше заданого значення:");
        bool found = false;

        for (int i = 0;i < workers.Length;i++) {
            int experience = currentYear - workers[i].YearStarted;
            if (experience < minExperience)
            {
                found = true;
                Console.WriteLine($"Прізвище: {workers[i].FullName}, Посада: {workers[i].Position}, Стаж: {experience} років");
            }
    }
        if(!found)
        {
            Console.WriteLine("Немає працівників зі стажем більше заданого значення.");
        }
    }
}