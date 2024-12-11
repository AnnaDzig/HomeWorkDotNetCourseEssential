using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Dictionary<TKey, TValue>
{
    private readonly List<TKey> keys = new List<TKey>();
    private readonly List<TValue> values = new List<TValue>();

    public void Add(TKey key, TValue value)
    {
        if (keys.Contains(key))
       
            throw new ArgumentException("Такий ключ уже існує.");
            keys.Add(key);
            values.Add(value);
        }

        public TValue this[TKey key]
    {

        get
        {
            int index = keys.IndexOf(key);
            if (index == -1)
                throw new ArgumentException("Ключ не знайдено.");
            return values[index];
        }
    }

    public int Count => keys.Count;
}

class Program
{
    static void Main()
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var dictionary = new Dictionary<string, int>();

        dictionary.Add("Apple", 10);
        dictionary.Add("Orange", 15);
        dictionary.Add("Kiwi", 9);


        Console.WriteLine($"Кількість яблук: {dictionary["Apple"]} ");
        Console.WriteLine($"Кількість апельсин:{dictionary["Orange"]}");
        Console.WriteLine($"Кількість ківі:{dictionary["Kiwi"]}");

        Console.WriteLine($"Загальна кількість пар у словнику: {dictionary.Count}");

        try
        {
            dictionary.Add("Kiwi", 50);
        }
        catch (ArgumentException ex)
        { Console.WriteLine($"Error:{ex.Message}");
        }
    }
}