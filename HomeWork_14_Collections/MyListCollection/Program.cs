// Створіть колекцію MyList. Реалізуйте у найпростішому наближенні можливість використання її екземпляра аналогічно екземпляру класу List.
// Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента, індексатор для отримання значення
// елемента за вказаним індексом і властивість тільки для читання для отримання загальної кількості елементів. Реалізуйте можливість
// перебору елементів колекції у циклі наперед.

// створити клас MyList, який:
//1. Дозволяє додавати елементи (як List.Add).
//2. Дозволяє отримувати елемент за індексом (як List[index]).
//3. Показує кількість елементів у списку (як List.Count).
//4. Дозволяє перебирати елементи в циклі foreach.

using MyListCollection;

class Program
{
    static void Main()
    {
        MyList<int> myList = new MyList<int>();

        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        Console.WriteLine("Element with index 1: " + myList[1]);

        Console.WriteLine("Number of elements: " + myList.Count);

        Console.WriteLine("List of elements:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}