using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3
{
    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good pupil studies well.");
        }

        public override void Read()
        {
            Console.WriteLine("Good pupil reads well.");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writes well.");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil sometimes relaxes.");
        }
    }


}
