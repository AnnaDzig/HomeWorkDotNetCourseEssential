using System;
using System.Text;


using DocumentWorker_task;

class Program
{
    static void Main(string[] args)
    {
        const string PRO_KEY = "pro";
        const string EXPERT_KEY = "exp";


        Console.OutputEncoding = Encoding.UTF8; 
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть ключ доступу (pro/exp), або натисніть Enter для безкоштовної версії:");
        string userKey = Console.ReadLine();

        DocumentWorker documentWorker;

        if (userKey == PRO_KEY)
        {
            documentWorker = new ProDocumentWorker();
        }
        else if (userKey == EXPERT_KEY)
        {
            documentWorker = new ExpertDocumentWorker();
        }
        else
        {
            documentWorker = new DocumentWorker();
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();

        Console.ReadKey();
    }
}