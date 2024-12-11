public abstract class AbstractHandler
{
    public abstract void Open();
    public abstract void Create();
    public abstract void Change();
    public abstract void Save();

}

public class XMLHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("XML файл відкрито.");
    public override void Create() => Console.WriteLine("XML файл створено.");
    public override void Change() => Console.WriteLine("XML файл змінено.");
    public override void Save() => Console.WriteLine("XML файл збережено.");
}


public class TXTHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("TXT файл відкрито.");
    public override void Create() => Console.WriteLine("TXT файл створено.");
    public override void Change() => Console.WriteLine("TXT файл змінено.");
    public override void Save() => Console.WriteLine("TXT файл збережено.");
}
public class DOCHandler : AbstractHandler
{
    public override void Open() => Console.WriteLine("DOC файл відкрито.");
    public override void Create() => Console.WriteLine("DOC файл створено.");
    public override void Change() => Console.WriteLine("DOC файл змінено.");
    public override void Save() => Console.WriteLine("DOC файл збережено.");
}

class Program
{
    static void Main(string[] args)
    { 

    Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть тип документа (XML, TXT, DOC):");
        string input = Console.ReadLine();

    AbstractHandler handler;

        switch (input.ToUpper())
        {
            case "XML":
                handler = new XMLHandler();
                break;
            case "TXT":
                handler = new TXTHandler();
                break;
            case "DOC":
                handler = new DOCHandler();
                break;
            default:
                Console.WriteLine("Невідомий формат документа.");
                return;
        }

Console.WriteLine("\nВиконуємо операції з документом:");
handler.Open();
handler.Create();
handler.Change();
handler.Save();
    }
}