using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker_task
{
    public class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ відкритий.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редагування документа доступне у версії Про.");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документа доступне у версії Про.");
        }
    }
}