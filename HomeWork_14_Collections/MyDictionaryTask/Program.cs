// Створіть колекцію MyDictionary. Реалізуйте у найпростішому наближенні можливість використання
// її екземпляра аналогічно екземпляру класу Dictionary. Мінімально необхідний інтерфейс
// взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для
// отримання значення елемента за вказаним індексом і властивість тільки для читання
// для отримання загальної кількості елементів. Реалізуйте можливість перебору
// елементів колекції у циклі наперед.

// Загальна структура MyDictionary
// зберігати пари ключ-значення у внутрішньому масиві.
//Клас підтримуватиме:
// 1. Метод для додавання елементів.
// 2. Індексатор для отримання значень за ключем.
// 3. Властивість Count для кількості елементів.
// 4. Ітерацію через foreach.

using MyDictionaryTask;

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

        // Додавання елементів
        myDictionary.Add("One", 1);
        myDictionary.Add("Two", 2);
        myDictionary.Add("Three", 3);

        // Доступ за ключем
        Console.WriteLine("Key 'Two': " + myDictionary["Two"]);

        // Кількість елементів
        Console.WriteLine("Count: " + myDictionary.Count);

        // Перебір у циклі foreach
        Console.WriteLine("All items:");
       
        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}