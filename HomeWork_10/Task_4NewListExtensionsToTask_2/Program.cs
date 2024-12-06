public class MyList<T>
{
    public List<T> _items = new List<T>();
    public void Add(T item)
    {
        _items.Add(item);
    }

    public T this[int index]
    {
        get
        {
            if (index >= 0 && index < _items.Count)
            {
                return _items[index];
            }
            throw new IndexOutOfRangeException("Неправильний індекс.");
        }
    }

    public int Count => _items.Count;
}

// Перша частина залишається без змін, додаємо розширюючий метод GetArray

public static class MyListExtensions
{
    public static T[] GetArrey<T>(this MyList<T> list)
    {
        return list._items.ToArray();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);



        Console.WriteLine($"Кількість елементів: {myList.Count}");

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine($"Елемент {i}: {myList[i]}");
        }


        // Використовуємо розширюючий метод GetArray

        int[] array = myList.GetArrey();

        Console.WriteLine("Елементи масиву:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }


    }
}
