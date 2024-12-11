public class MyClass
{
    public string change;
}

public struct MyStruct
{
    public string change;

}

class Program
{
static void ClassTaker(MyClass myClass)
    {
        myClass.change = "змінено";
    }
    static void StruktTaker(MyStruct myStruct)
    {
        myStruct.change = "змінено";
    }
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        MyClass myClass = new MyClass { change = "не змінено" };
        MyStruct myStruct = new MyStruct { change = "не змінено" };

        Console.WriteLine("Початкове значення поля change для класу: " + myClass.change);
        Console.WriteLine("Початкове значення поля change для структури: " + myStruct.change);


        ClassTaker(myClass); 
        StruktTaker(myStruct); 

        
        Console.WriteLine("\nПісля виклику ClassTaker:");
        Console.WriteLine("Значення поля change для класу: " + myClass.change);

        Console.WriteLine("\nПісля виклику StruktTaker:");
        Console.WriteLine("Значення поля change для структури: " + myStruct.change);

        Console.ReadKey();
    }
}