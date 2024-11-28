using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent pupil studies perfectly.");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent pupil reads excellently.");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil writes excellently.");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil rarely relaxes.");
        }
    }


}
