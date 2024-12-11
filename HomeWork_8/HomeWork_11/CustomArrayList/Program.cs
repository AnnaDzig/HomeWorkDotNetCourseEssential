class ArrayList
{
    private object[] items;
    private int count;


    public ArrayList()
    {
        items = new object[10];
        count = 0;
    }

    public void Add(object value)
    {
        if (count == items.Length)
            throw new InvalidOperationException("Масив переповнений.");

        items[count] = value;
        count++;
    }

    public object this[int index]
    { get
        { if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("index");
        return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("index");
            items[index] = value;
        }
    }
    public int Count => count;

}

class Program
{
    static void Main()
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var arrayList = new ArrayList();

        arrayList.Add(10);
        arrayList.Add(20);
        arrayList.Add(30);

        Console.WriteLine("Елементи:");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine($"Index {i}: {arrayList[i]}");
        }

        try
        {
            for (int i = 0; i < 20; i++)
            {
                arrayList.Add(i);
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"\nПомилка: {ex.Message}");
        }
    }
}

