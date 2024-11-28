using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad pupil studies poorly.");
        }

        public override void Read()
        {
            Console.WriteLine("Bad pupil reads poorly.");
        }

        public override void Write()
        {
            Console.WriteLine("Bad pupil writes poorly.");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad pupil relaxes a lot.");
        }
    }


}
