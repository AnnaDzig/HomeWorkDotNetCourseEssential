
    class Program
    {
        static void Main(string[] args)
        {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть вашу дату народження (в форматі день місяць рік ставлячи пробіл після кожного значення  ): ");
            string input = Console.ReadLine();

            DateTime birthDate;
            if (DateTime.TryParse(input, out birthDate))
            {
                DateTime currentDate = DateTime.Today;

                DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

                if (nextBirthday < currentDate)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                int daysUntilBirthday = (nextBirthday - currentDate).Days;

                Console.WriteLine($"До наступного дня народження залишилось {daysUntilBirthday} днів.");
            }
            else
            {
                Console.WriteLine("Введена дата некоректна. Будь ласка, введіть дату у правильному форматі.");
            }

            Console.ReadKey();
        }
    }


