using System;
using System.Collections; 

class Program
{
    static void Main()
    {

        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ArrayList arrayList = new ArrayList();

        arrayList.Add(42);               
        arrayList.Add(3.14);             
        arrayList.Add("Hello, world!");  
        arrayList.Add(DateTime.Now);     
        arrayList.Add(new object());    

        Console.WriteLine("Елементи в ArrayList:");
        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine($"Index {i}: {arrayList[i]}");
        }

        try
        {
            int value = (int)arrayList[0]; 
            Console.WriteLine($"\nКоректне приведення: {value}");

            value = (int)arrayList[1]; 
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"\nПомилка: {ex.Message}");
        }
    }
}

//  Коли ми запустили код, то зіткнулися з тим, що `ArrayList` дозволяє додавати елементи різних типів,
//  але при доступі до них потрібно явно приводити їх до потрібного типу. Якщо тип елемента не
//  відповідає очікуваному, виникає виняток `InvalidCastException`. Це трапляється через те, що `ArrayList`
//  не підтримує перевірку типів на етапі компіляції, що робить код менш надійним і схильним до помилок
//  під час виконання.
