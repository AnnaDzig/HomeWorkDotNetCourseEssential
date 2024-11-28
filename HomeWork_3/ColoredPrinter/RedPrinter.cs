using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredPrinter
{
    public class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
