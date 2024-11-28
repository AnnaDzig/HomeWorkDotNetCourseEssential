// See https://aka.ms/new-console-template for more information
using ColoredPrinter;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Printer defaultPrinter = new Printer();
        defaultPrinter.Print("Це текст з білого принтера");

        Printer redPrinter = new RedPrinter();
        redPrinter.Print("Це текст з червоного принтера");

        Printer greenPrinter = new YellowPrinter();
        greenPrinter.Print("Це текст з жовтого принтера");

   
        Console.ReadLine();
    }
}

