// See Завдання 2
// Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: Equals - здатний
// порівнювати блоки між собою, ToString - повертає інформацію про поля блоку.
// Завдання 3
// Створіть клас House з двома полями та властивостями. Створіть два методи Clone() та
// DeepClone(), які виконують поверхневе та глибоке копіювання відповідно. Реалізуйте найпростіший спосіб перевірки.
// Завдання 4
// Створіть клас, який містить інформацію про дату (день, місяць, рік). За допомогою механізму перевантаження операторів
// визначте операцію різниці двох дат (результат у вигляді кількості днів між датами), а також операцію збільшення дати на певне кількість днів. 

using Tasks_2_3_4;

class Program
{
    static void Main ()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Block block1 = new Block(10, 20, 30, 40);
        Block block2 = new Block(10, 20, 30, 40);
        Block block3 = new Block(15, 25, 35, 45);


        // Використовуємо ToString для виведення інформації про блок
        Console.WriteLine (block1);


        // Перевіряємо, чи рівні блоки
        Console.WriteLine(block1.Equals(block2)); 
        Console.WriteLine(block1.Equals(block3));

        // Завдання 3
        House originalHouse = new House("Stadionvej 41A", new Owner ("Anna Dzhyhota"));

        // Поверхнева копія
        House copy = originalHouse.Clone();

        // Глибока копія
        House deepCopy = originalHouse.DeepClone();

        originalHouse.Address = "Vajlevaj 100";
        originalHouse.OwnerInfo.Name = "Marcin Malkievich";

        Console.WriteLine("Original House: " + originalHouse);
        Console.WriteLine("Shallow Copy: " + copy);
        Console.WriteLine("Deep Copy: " + deepCopy);

        // Завдання 4

        DateInfo date1 = new DateInfo(10, 12, 2024);
        DateInfo date2 = new DateInfo(4, 1, 2025);

        int daysDifference = date1 - date2;
        Console.WriteLine($"Різниця між {date1} і {date2}: {daysDifference} днів");

        DateInfo newDate = date1 + 30;
        Console.WriteLine($"Дата {date1} після додавання 30 днів: {newDate}");

        Console.WriteLine($"{date2}" + daysDifference + daysDifference);
        DateInfo date3 = newDate + daysDifference;
    }
}